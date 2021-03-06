﻿using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDashTable
{
    public class Html2List
    {
        private const string table = "table";
        private const string tr = "tr";
        private const string td = "td";
        private const string rowspan = "rowspan";
        private const string colspan = "colspan";

        private bool existsAlready(int idx_row, int idx_col, List<SpanCell> spanList)
        {
            return spanList.Any(cell => 
            cell.Position.Item1 == idx_row 
            && cell.Position.Item2 == idx_col);
        }

        private Tout createSpan<Tout>(int idx = 0, string value = null)
            where Tout : Span
        {
            int index = idx;
            int val = !String.IsNullOrEmpty(value) 
                ? Convert.ToInt32(value)
                : 1;
            if(typeof(Tout) == typeof(Rowspan))
            {
                return (Tout)(object)new Rowspan
                {
                    Index = index,
                    Value = val
                };
            } else if(typeof(Tout) == typeof(Colspan))
            {
                return (Tout)(object)new Colspan
                {
                    Index = index,
                    Value = val
                };
            }
            return default(Tout);
        }

        private List<List<Cell>> createTableRepresentation(HtmlNode[] allRows)
        {
            var listOfCellLists = new List<List<Cell>>();
            int rowspan_idx = 1;
            int colspan_idx = 1;
            for (int idx_row = 0; idx_row < allRows.Length; idx_row++)
            {
                var aRow = new List<Cell>();
                var row = allRows[idx_row];
                var allCols = row.Descendants(td);

                foreach (var col in allCols)
                {
                    var cell = new Cell();
                    cell.Text = col.InnerText.Trim();

                    var rowspanAttr = col.Attributes.FirstOrDefault(attr => attr.Name == rowspan);
                    if (rowspanAttr != null)
                    {
                        cell.Rowspan = createSpan<Rowspan>(rowspan_idx++, rowspanAttr.Value);
                    }
                    else
                    {
                        cell.Rowspan = createSpan<Rowspan>();
                    }

                    var colspanAttr = col.Attributes.FirstOrDefault(attr => attr.Name == colspan);
                    if (colspanAttr != null)
                    {
                        cell.Colspan = createSpan<Colspan>(colspan_idx++, colspanAttr.Value);
                    }
                    else
                    {
                        cell.Colspan = createSpan<Colspan>();
                    }
                    aRow.Add(cell);
                }
                listOfCellLists.Add(aRow);
            }
            return listOfCellLists;
        }

        private SpanCell createSpanCell(string text, int positionA, int positionB, int colspanIndex, int rowspanIndex)
        {
            return new SpanCell
            {
                Text = text,
                Position = Tuple.Create(positionA, positionB),
                ColspanIndex = colspanIndex,
                RowspanIndex = rowspanIndex
            };
        }

        private List<SpanCell> createSpanCellList(List<List<Cell>> listOfCellLists)
        {
            var spanCellList = new List<SpanCell>();
            int colspanIndex = 1;
            int rowspanIndex = 1;
            int currentIdxRow = -1;

            for(int idx_row = 0; idx_row < listOfCellLists.Count; idx_row++)
            {
                var row = listOfCellLists[idx_row];
                currentIdxRow++;
                int currentIdxCol = -1;


                for (int idx_col = 0; idx_col < row.Count; idx_col++)
                {
                    var cell = row[idx_col];

                    var isExisting = true;
                    while (isExisting)
                    {
                        if(existsAlready(currentIdxRow, currentIdxCol, spanCellList))
                        {
                            currentIdxCol++;
                        }
                        else
                        {
                            isExisting = false;
                        }
                    }


                    int newPositionA;
                    int newPositionB;
                    if(cell.Rowspan.Index != 0 && cell.Colspan.Index != 0)
                    {
                        spanCellList.Add(createSpanCell(cell.Text, currentIdxRow, currentIdxCol, colspanIndex, rowspanIndex));
                        var rowToChange = cell.Rowspan.Value;
                        foreach (var rspanNb in Enumerable.Range(0, rowToChange - 1))
                        {
                            newPositionA = currentIdxRow + 1 + rspanNb;
                            spanCellList.Add(createSpanCell(String.Empty, newPositionA, currentIdxCol, colspanIndex, rowspanIndex));
                        }
                        int previousCurrIdxCol = currentIdxCol;

                        foreach (int theRowToChange in Enumerable.Range(0, cell.Rowspan.Value))
                        {
                            foreach (int cspanNb in Enumerable.Range(0, cell.Colspan.Value -1))
                            {
                                newPositionA = currentIdxRow + theRowToChange;
                                newPositionB = currentIdxCol + 1 + cspanNb;
                                spanCellList.Add(createSpanCell(String.Empty, newPositionA, newPositionB, colspanIndex, rowspanIndex));
                                if(theRowToChange == 0) { previousCurrIdxCol++; }
                            }
                        }
                        currentIdxCol = previousCurrIdxCol;
                        colspanIndex++;
                        rowspanIndex++;
                    }
                    else if(cell.Rowspan.Index != 0)
                    {
                        spanCellList.Add(createSpanCell(cell.Text, currentIdxRow, currentIdxCol, 0, rowspanIndex));
                        foreach (int rspanNb in Enumerable.Range(0, cell.Rowspan.Value -1))
                        {
                            newPositionA = currentIdxRow + 1 + rspanNb;
                            spanCellList.Add(createSpanCell(String.Empty, newPositionA, currentIdxCol, 0, rowspanIndex));
                        }
                        rowspanIndex++;
                    }
                    else if(cell.Colspan.Index != 0)
                    {
                        spanCellList.Add(createSpanCell(cell.Text, currentIdxRow, currentIdxCol, colspanIndex, 0));
                        foreach (int cspanValue in Enumerable.Range(0, cell.Colspan.Value - 1))
                        {
                            newPositionB = currentIdxCol + 1 + cspanValue;
                            spanCellList.Add(createSpanCell(String.Empty, currentIdxRow, newPositionB, colspanIndex, 0));
                            currentIdxCol++;
                        }
                        colspanIndex++;
                    }
                    else
                    {
                        spanCellList.Add(createSpanCell(cell.Text, currentIdxRow, currentIdxCol, 0, 0));
                    }
                }
            }
            return spanCellList.OrderBy(cell => cell.Position).ToList();
        }

        private Tuple<NegativeIndexList<List<string>>, NegativeIndexList<List<int>>, NegativeIndexList<List<int>>> 
            createFinalResult(List<SpanCell> spancellList)
        {
            // data structure
            // datalist = [["t1","t2".."tN"], [],[],[]..[]]
            // rowspan_list = [[ri1,ri2..riN],[],[],[]..[]]
            // colspan_list = [[ci1,ci2..ciN],[],[],[]..[]]

            var datalist = new NegativeIndexList<List<string>>();
            var rowspan = new NegativeIndexList<List<int>>();
            var colspan = new NegativeIndexList<List<int>>();

            datalist[-1] = new List<string>();
            rowspan[-1] = new List<int>();
            colspan[-1] = new List<int>();

            int idx_row = -1;
            foreach (var cell in spancellList)
            {
                if(idx_row != cell.Position.Item1)
                {
                    datalist.Add(new List<string>());
                    rowspan.Add(new List<int>());
                    colspan.Add(new List<int>());
                    idx_row++;
                }
                datalist[-1].Add(cell.Text);
                rowspan[-1].Add(cell.RowspanIndex);
                colspan[-1].Add(cell.ColspanIndex);

            }
            return Tuple.Create(datalist, rowspan, colspan);
        }


        public Tuple<NegativeIndexList<List<string>>, NegativeIndexList<List<int>>, NegativeIndexList<List<int>>> Create(string htmlString)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(htmlString);
            var tableElem = doc.DocumentNode.Descendants(table).FirstOrDefault();

            var allRows = tableElem.Descendants(tr).ToArray();
            var tableRepresentation = createTableRepresentation(allRows);
            var spancellList = createSpanCellList(tableRepresentation);
            var returnResult = createFinalResult(spancellList);
            return returnResult;
        }



    }
}
