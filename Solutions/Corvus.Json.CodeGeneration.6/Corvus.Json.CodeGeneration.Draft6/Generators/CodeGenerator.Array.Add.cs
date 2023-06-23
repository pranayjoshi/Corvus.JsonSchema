//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:7.0.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Corvus.Json.CodeGeneration.Generators.Draft6 {
    using System.Collections.Generic;
    using Corvus.Json;
    using System;
    
    
    public partial class CodeGeneratorArrayAdd : CodeGeneratorArrayAddBase {
        
        
        #line 123 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"

    public bool ShouldGenerate
    {
        get
        {
            return IsImplicitArray || IsNotImplicitType;
        }
    }

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"

    // This is only emitted if IsImplicitArray is true
    if(!ShouldGenerate)
    {
        throw new InvalidOperationException("CodeGenerator.Array.Add should not be emitted if IsImplicitArray is false.");
    } 
            
            #line default
            #line hidden
            
            #line 10 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(@"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable

using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using Corvus.Json;

namespace ");
            
            #line default
            #line hidden
            
            #line 25 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 25 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 27 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 28 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write("/// <summary>\r\n/// A type generated from a JsonSchema specification.\r\n/// </summa" +
                    "ry>\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 31 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 31 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write("\r\n{\r\n    /// <inheritdoc/>\r\n    public ");
            
            #line default
            #line hidden
            
            #line 34 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 34 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(" Add(in JsonAny item1)\r\n    {\r\n        ImmutableList<JsonAny>.Builder builder = t" +
                    "his.GetImmutableListBuilder();\r\n        builder.Add(item1);\r\n        return new(" +
                    "builder.ToImmutable());\r\n    }\r\n\r\n    /// <inheritdoc/>\r\n    public ");
            
            #line default
            #line hidden
            
            #line 42 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 42 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(" Add(params JsonAny[] items)\r\n    {\r\n        ImmutableList<JsonAny>.Builder build" +
                    "er = this.GetImmutableListBuilder();\r\n        builder.AddRange(items);\r\n        " +
                    "return new(builder.ToImmutable());\r\n    }\r\n\r\n    /// <inheritdoc/>\r\n    public ");
            
            #line default
            #line hidden
            
            #line 50 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 50 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(@" AddRange<TArray>(in TArray items)
        where TArray : struct, IJsonArray<TArray>
    {
        ImmutableList<JsonAny>.Builder builder = this.GetImmutableListBuilder();
        foreach (JsonAny item in items.EnumerateArray())
        {
            builder.Add(item.AsAny);
        }

        return new(builder.ToImmutable());
    }

    /// <inheritdoc/>
    public ");
            
            #line default
            #line hidden
            
            #line 63 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 63 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(@" AddRange<TItem>(IEnumerable<TItem> items)
        where TItem : struct, IJsonValue<TItem>
    {
        ImmutableList<JsonAny>.Builder builder = this.GetImmutableListBuilder();
        foreach (TItem item in items)
        {
            builder.Add(item.AsAny);
        }

        return new(builder.ToImmutable());
    }

    /// <inheritdoc/>
    public ");
            
            #line default
            #line hidden
            
            #line 76 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 76 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(" AddRange(IEnumerable<JsonAny> items)\r\n    {\r\n        ImmutableList<JsonAny>.Buil" +
                    "der builder = this.GetImmutableListBuilder();\r\n        builder.AddRange(items);\r" +
                    "\n        return new(builder.ToImmutable());\r\n    }\r\n\r\n    /// <inheritdoc/>\r\n   " +
                    " public ");
            
            #line default
            #line hidden
            
            #line 84 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 84 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(" Insert(int index, in JsonAny item1)\r\n    {\r\n        return new(this.GetImmutable" +
                    "ListWith(index, item1));\r\n    }\r\n\r\n    /// <inheritdoc/>\r\n    public ");
            
            #line default
            #line hidden
            
            #line 90 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 90 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(" InsertRange<TArray>(int index, in TArray items)\r\n        where TArray : struct, " +
                    "IJsonArray<TArray>\r\n    {\r\n        return new(this.GetImmutableListWith(index, i" +
                    "tems.EnumerateArray()));\r\n    }\r\n\r\n    /// <inheritdoc/>\r\n    public ");
            
            #line default
            #line hidden
            
            #line 97 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 97 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(" InsertRange<TItem>(int index, IEnumerable<TItem> items)\r\n        where TItem : s" +
                    "truct, IJsonValue<TItem>\r\n    {\r\n        return new(this.GetImmutableListWith(in" +
                    "dex, items.Select(item => item.AsAny)));\r\n    }\r\n\r\n    /// <inheritdoc/>\r\n    pu" +
                    "blic ");
            
            #line default
            #line hidden
            
            #line 104 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 104 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(" InsertRange(int index, IEnumerable<JsonAny> items)\r\n    {\r\n        return new(th" +
                    "is.GetImmutableListWith(index, items));\r\n    }\r\n\r\n    /// <inheritdoc/>\r\n    pub" +
                    "lic ");
            
            #line default
            #line hidden
            
            #line 110 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 110 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(" Replace(in JsonAny oldValue, in JsonAny newValue)\r\n    {\r\n        return this.Ge" +
                    "tImmutableListReplacing(oldValue.AsAny, newValue.AsAny);\r\n    }\r\n\r\n    /// <inhe" +
                    "ritdoc/>\r\n    public ");
            
            #line default
            #line hidden
            
            #line 116 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 116 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write(" SetItem(int index, in JsonAny value)\r\n    {\r\n        return this.GetImmutableLis" +
                    "tSetting(index, value.AsAny);\r\n    }\r\n}\r\n");
            
            #line default
            #line hidden
            
            #line 121 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
 EndNesting(); 
            
            #line default
            #line hidden
            
            #line 122 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Array.Add.tt"
            this.Write("\r\n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CodeGeneratorArrayAddBase {
        
        private global::System.Text.StringBuilder builder;
        
        private global::System.Collections.Generic.IDictionary<string, object> session;
        
        private global::System.CodeDom.Compiler.CompilerErrorCollection errors;
        
        private string currentIndent = string.Empty;
        
        private global::System.Collections.Generic.Stack<int> indents;
        
        private ToStringInstanceHelper _toStringHelper = new ToStringInstanceHelper();
        
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session {
            get {
                return this.session;
            }
            set {
                this.session = value;
            }
        }
        
        public global::System.Text.StringBuilder GenerationEnvironment {
            get {
                if ((this.builder == null)) {
                    this.builder = new global::System.Text.StringBuilder();
                }
                return this.builder;
            }
            set {
                this.builder = value;
            }
        }
        
        protected global::System.CodeDom.Compiler.CompilerErrorCollection Errors {
            get {
                if ((this.errors == null)) {
                    this.errors = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errors;
            }
        }
        
        public string CurrentIndent {
            get {
                return this.currentIndent;
            }
        }
        
        private global::System.Collections.Generic.Stack<int> Indents {
            get {
                if ((this.indents == null)) {
                    this.indents = new global::System.Collections.Generic.Stack<int>();
                }
                return this.indents;
            }
        }
        
        public ToStringInstanceHelper ToStringHelper {
            get {
                return this._toStringHelper;
            }
        }
        
        public void Error(string message) {
            this.Errors.Add(new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message));
        }
        
        public void Warning(string message) {
            global::System.CodeDom.Compiler.CompilerError val = new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message);
            val.IsWarning = true;
            this.Errors.Add(val);
        }
        
        public string PopIndent() {
            if ((this.Indents.Count == 0)) {
                return string.Empty;
            }
            int lastPos = (this.currentIndent.Length - this.Indents.Pop());
            string last = this.currentIndent.Substring(lastPos);
            this.currentIndent = this.currentIndent.Substring(0, lastPos);
            return last;
        }
        
        public void PushIndent(string indent) {
            this.Indents.Push(indent.Length);
            this.currentIndent = (this.currentIndent + indent);
        }
        
        public void ClearIndent() {
            this.currentIndent = string.Empty;
            this.Indents.Clear();
        }
        
        public void Write(string textToAppend) {
            this.GenerationEnvironment.Append(textToAppend);
        }
        
        public void Write(string format, params object[] args) {
            this.GenerationEnvironment.AppendFormat(format, args);
        }
        
        public void WriteLine(string textToAppend) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendLine(textToAppend);
        }
        
        public void WriteLine(string format, params object[] args) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendFormat(format, args);
            this.GenerationEnvironment.AppendLine();
        }
        
        public class ToStringInstanceHelper {
            
            private global::System.IFormatProvider formatProvider = global::System.Globalization.CultureInfo.InvariantCulture;
            
            public global::System.IFormatProvider FormatProvider {
                get {
                    return this.formatProvider;
                }
                set {
                    if ((value != null)) {
                        this.formatProvider = value;
                    }
                }
            }
            
            public string ToStringWithCulture(object objectToConvert) {
                if ((objectToConvert == null)) {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                global::System.Type type = objectToConvert.GetType();
                global::System.Type iConvertibleType = typeof(global::System.IConvertible);
                if (iConvertibleType.IsAssignableFrom(type)) {
                    return ((global::System.IConvertible)(objectToConvert)).ToString(this.formatProvider);
                }
                global::System.Reflection.MethodInfo methInfo = type.GetMethod("ToString", new global::System.Type[] {
                            iConvertibleType});
                if ((methInfo != null)) {
                    return ((string)(methInfo.Invoke(objectToConvert, new object[] {
                                this.formatProvider})));
                }
                return objectToConvert.ToString();
            }
        }
    }
}
