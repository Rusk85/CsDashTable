﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CsDashTableTester {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class TestResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TestResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CsDashTableTester.TestResources", typeof(TestResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;table border=1&gt;
        ///  &lt;caption&gt;A test table witd merged cells&lt;/caption&gt;
        ///  &lt;tr&gt;
        ///  &lt;td&gt;Name&lt;/td&gt;
        ///  &lt;td colspan=2&gt;Features&lt;/td&gt;
        ///  &lt;td colspan=2&gt;Job&lt;/td&gt;
        ///  &lt;/tr&gt;
        ///  &lt;tr&gt;
        ///  &lt;td&gt;Jack&lt;/td&gt;
        ///  &lt;td&gt;1.9m&lt;/td&gt;
        ///  &lt;td&gt;75Kg&lt;/td&gt;
        ///  &lt;td&gt;graphist&lt;/td&gt;
        ///  &lt;td&gt;gardener&lt;/td&gt;
        ///  &lt;/tr&gt;
        ///  &lt;tr&gt;
        ///  &lt;td colspan=3&gt;Other features&lt;/td&gt;
        ///  &lt;td&gt;developer&lt;/td&gt;
        ///  &lt;td&gt;painter&lt;/td&gt;
        ///  &lt;/tr&gt;
        ///&lt;/table&gt;
        ///
        ///&lt;!--  expected result:
        ///          A test table witd merged cells
        ///+----------+-------------------+----------+-----------+
        ///| Name    [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string colspan_input {
            get {
                return ResourceManager.GetString("colspan_input", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;table border=1&gt;
        ///  &lt;caption&gt;A test table witd merged cells&lt;/caption&gt;
        ///  &lt;tr&gt;
        ///  &lt;td&gt;Name&lt;/td&gt;
        ///  &lt;td&gt;Height&lt;/td&gt;
        ///  &lt;td&gt;Weight&lt;/td&gt;
        ///  &lt;td&gt;Jobs&lt;/td&gt;
        ///  &lt;td&gt;Hobby&lt;/td&gt;
        ///  &lt;/tr&gt;
        ///  &lt;tr&gt;
        ///  &lt;td&gt;Jack&lt;/td&gt;
        ///  &lt;td colspan=2 rowspan=2&gt;Undisclosed&lt;/td&gt;
        ///  &lt;td&gt;graphist&lt;/td&gt;
        ///  &lt;td&gt;gardener&lt;/td&gt;
        ///  &lt;/tr&gt;
        ///  &lt;tr&gt;
        ///  &lt;td&gt;Frank&lt;/td&gt;
        ///  &lt;td&gt;developer&lt;/td&gt;
        ///  &lt;td&gt;painter&lt;/td&gt;
        ///  &lt;/tr&gt;
        ///  &lt;tr&gt;
        ///  &lt;td&gt;Jenny&lt;/td&gt;
        ///  &lt;td&gt;1.6m&lt;/td&gt;
        ///  &lt;td&gt;52Kg&lt;/td&gt;
        ///  &lt;td&gt;commercial&lt;/td&gt;
        ///  &lt;td&gt;jogger&lt;/td&gt;
        ///  &lt;/tr&gt;
        ///&lt;/table&gt;
        ///
        ///&lt;!--  expected [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string colspanANDrowspan_input {
            get {
                return ResourceManager.GetString("colspanANDrowspan_input", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;table border=&quot;solid black&quot;&gt;
        ///&lt;tr&gt;
        ///&lt;td&gt;aaaa&lt;/td&gt;
        ///&lt;td colspan=2&gt;COLSPAN&lt;/td&gt;
        ///&lt;td rowspan=2&gt;ROWSPAN&lt;/td&gt;
        ///&lt;/tr&gt;
        ///&lt;tr&gt;
        ///&lt;td&gt;jj&lt;/td&gt;
        ///&lt;td&gt;under_COLSPAN1&lt;/td&gt;
        ///&lt;td&gt;under_COLSPAN2&lt;/td&gt;
        ///&lt;/tr&gt;
        ///&lt;tr&gt;
        ///&lt;td&gt;fff&lt;/td&gt;
        ///&lt;td&gt;kk&lt;/td&gt;
        ///&lt;td&gt;hhhhh&lt;/td&gt;
        ///&lt;td&gt;iii&lt;/td&gt;
        ///&lt;/tr&gt;
        ///&lt;/table&gt;
        ///.
        /// </summary>
        internal static string colspanANDrowspan2 {
            get {
                return ResourceManager.GetString("colspanANDrowspan2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;table border=1&gt;
        ///  &lt;caption&gt;A test table witd merged cells&lt;/caption&gt;
        ///  &lt;tr&gt;
        ///  &lt;td rowspan=2&gt;Name&lt;/td&gt;
        ///  &lt;td colspan=2&gt;Features&lt;/td&gt;
        ///  &lt;td rowspan=2&gt;Job&lt;/td&gt;
        ///  &lt;/tr&gt;
        ///  &lt;tr&gt;
        ///  &lt;td&gt;height&lt;/td&gt;
        ///  &lt;td&gt;weight&lt;/td&gt;
        ///  &lt;/tr&gt;
        ///  &lt;tr&gt;
        ///  &lt;td&gt;Jack&lt;/td&gt;
        ///  &lt;td&gt;1.9m&lt;/td&gt;
        ///  &lt;td&gt;75Kg&lt;/td&gt;
        ///  &lt;td&gt;graphist&lt;/td&gt;
        ///  &lt;/tr&gt;
        ///  &lt;tr&gt;
        ///  &lt;td&gt;Cherry&lt;/td&gt;
        ///  &lt;td&gt;1.7m&lt;/td&gt;
        ///  &lt;td&gt;56Kg&lt;/td&gt;
        ///  &lt;td&gt;developer&lt;/td&gt;
        ///  &lt;/tr&gt;
        ///&lt;/table&gt;
        ///
        ///&lt;!--  expected result:
        ///          A test table witd merged cells
        ///+----------+-------------- [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string original__input {
            get {
                return ResourceManager.GetString("original__input", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;table border=1&gt;
        ///  &lt;caption&gt;A test table witd merged cells&lt;/caption&gt;
        ///  &lt;tr&gt;
        ///  &lt;td rowspan=2&gt;Name&lt;/td&gt;
        ///  &lt;td&gt;size&lt;/td&gt;
        ///  &lt;td&gt;Kg&lt;/td&gt;
        ///  &lt;td rowspan=2&gt;Job&lt;/td&gt;
        ///  &lt;/tr&gt;
        ///  &lt;tr&gt;
        ///  &lt;td&gt;height&lt;/td&gt;
        ///  &lt;td&gt;weight&lt;/td&gt;
        ///  &lt;/tr&gt;
        ///  &lt;tr&gt;
        ///  &lt;td rowspan=3&gt;Other&lt;/td&gt;
        ///  &lt;td&gt;1.9m&lt;/td&gt;
        ///  &lt;td&gt;75Kg&lt;/td&gt;
        ///  &lt;td&gt;graphist&lt;/td&gt;
        ///  &lt;/tr&gt;
        ///  &lt;tr&gt;
        ///  &lt;td&gt;1.7m&lt;/td&gt;
        ///  &lt;td&gt;56Kg&lt;/td&gt;
        ///  &lt;td&gt;developer&lt;/td&gt;
        ///  &lt;/tr&gt;
        ///  &lt;tr&gt;
        ///  &lt;td&gt;2.0m&lt;/td&gt;
        ///  &lt;td&gt;80Kg&lt;/td&gt;
        ///  &lt;td&gt;algorist&lt;/td&gt;
        ///  &lt;/tr&gt;
        ///&lt;/table&gt;
        ///
        ///&lt;!--  expected result:
        ///    [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string rowspan_input {
            get {
                return ResourceManager.GetString("rowspan_input", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;table border=1&gt;
        ///  &lt;caption&gt;A test table witd merged cells&lt;/caption&gt;
        ///  &lt;tr&gt;
        ///  &lt;td&gt;Name&lt;/td&gt;
        ///  &lt;td&gt;Height&lt;/td&gt;
        ///  &lt;td&gt;Weight&lt;/td&gt;
        ///  &lt;td&gt;Jobs&lt;/td&gt;
        ///  &lt;td&gt;Hobby&lt;/td&gt;
        ///  &lt;/tr&gt;
        ///  &lt;tr&gt;
        ///  &lt;td&gt;Jack&lt;/td&gt;
        ///  &lt;td&gt;1.9m&lt;/td&gt;
        ///  &lt;td&gt;75Kg&lt;/td&gt;
        ///  &lt;td&gt;graphist&lt;/td&gt;
        ///  &lt;td&gt;gardener&lt;/td&gt;
        ///  &lt;/tr&gt;
        ///  &lt;tr&gt;
        ///  &lt;td&gt;Jenny&lt;/td&gt;
        ///  &lt;td&gt;1.6m&lt;/td&gt;
        ///  &lt;td&gt;56Kg&lt;/td&gt;
        ///  &lt;td&gt;developer&lt;/td&gt;
        ///  &lt;td&gt;painter&lt;/td&gt;
        ///  &lt;/tr&gt;
        ///&lt;/table&gt;
        ///
        ///&lt;!--  expected result:
        ///          A test table witd merged cells
        ///+----------+-------------------+--- [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string simple_input {
            get {
                return ResourceManager.GetString("simple_input", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;table border=&quot;solid black&quot;&gt;
        ///&lt;tr&gt;
        ///&lt;td&gt;aaaa&lt;/td&gt;
        ///&lt;td&gt;zzzz&lt;/td&gt;
        ///&lt;td&gt;yyy&lt;/td&gt;
        ///&lt;td rowspan=2&gt;ROWSPAN&lt;/td&gt;
        ///&lt;/tr&gt;
        ///&lt;tr&gt;
        ///&lt;td&gt;jj&lt;/td&gt;
        ///&lt;td&gt;under_zzz&lt;/td&gt;
        ///&lt;td&gt;under_yyy&lt;/td&gt;
        ///&lt;/tr&gt;
        ///&lt;tr&gt;
        ///&lt;td&gt;fff&lt;/td&gt;
        ///&lt;td&gt;kk&lt;/td&gt;
        ///&lt;td&gt;hhhhh&lt;/td&gt;
        ///&lt;td&gt;iii&lt;/td&gt;
        ///&lt;/tr&gt;
        ///&lt;/table&gt;
        ///.
        /// </summary>
        internal static string simplerowspan_input {
            get {
                return ResourceManager.GetString("simplerowspan_input", resourceCulture);
            }
        }
    }
}
