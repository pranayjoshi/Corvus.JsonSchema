//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Corvus.Json.CodeGeneration.Generators.Draft202012 {
    using System.Collections.Generic;
    using Corvus.Json;
    using System;
    
    
    public partial class CodeGeneratorValidateOneOf : CodeGeneratorValidateOneOfBase {
        
        
        #line 126 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"

    public bool ShouldGenerate
    {
        get
        {
            return HasOneOf;
        }
    }

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"

    // This is only emitted if HasOneOf is true
    if(!ShouldGenerate)
    {
        throw new InvalidOperationException("CodeGenerator.Validate.OneOf should not be emitted if HasOneOf is false.");
    } 
            
            #line default
            #line hidden
            
            #line 10 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(@"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable

using Corvus.Json;

namespace ");
            
            #line default
            #line hidden
            
            #line 23 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 23 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 25 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 26 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write("/// <summary>\r\n/// A type generated from a JsonSchema specification.\r\n/// </summa" +
                    "ry>\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 29 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 29 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(@"
{
    private ValidationContext ValidateOneOf(in ValidationContext validationContext, ValidationLevel level)
    {
        ValidationContext result = validationContext;

        if (level > ValidationLevel.Basic)
        {
            result = result.PushValidationLocationProperty(""oneOf"");
        }

        ValidationContext childContextBase = result;

        int oneOfCount = 0;
");
            
            #line default
            #line hidden
            
            #line 43 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
  int oneOfIndex = 0;
    foreach (var oneOf in OneOf)
    { 
            
            #line default
            #line hidden
            
            #line 46 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write("\r\n        ValidationContext childContext");
            
            #line default
            #line hidden
            
            #line 47 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( oneOfIndex ));
            
            #line default
            #line hidden
            
            #line 47 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(" = childContextBase;\r\n        if (level > ValidationLevel.Basic)\r\n        {\r\n    " +
                    "        childContext");
            
            #line default
            #line hidden
            
            #line 50 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( oneOfIndex ));
            
            #line default
            #line hidden
            
            #line 50 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(" = childContext");
            
            #line default
            #line hidden
            
            #line 50 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( oneOfIndex ));
            
            #line default
            #line hidden
            
            #line 50 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(".PushValidationLocationArrayIndex(");
            
            #line default
            #line hidden
            
            #line 50 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( oneOfIndex ));
            
            #line default
            #line hidden
            
            #line 50 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(");\r\n        }\r\n\r\n        ValidationContext oneOfResult");
            
            #line default
            #line hidden
            
            #line 53 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( oneOfIndex));
            
            #line default
            #line hidden
            
            #line 53 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(" = this.As<");
            
            #line default
            #line hidden
            
            #line 53 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( oneOf ));
            
            #line default
            #line hidden
            
            #line 53 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(">().Validate(childContext");
            
            #line default
            #line hidden
            
            #line 53 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( oneOfIndex ));
            
            #line default
            #line hidden
            
            #line 53 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(".CreateChildContext(), level);\r\n\r\n        if (oneOfResult");
            
            #line default
            #line hidden
            
            #line 55 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( oneOfIndex ));
            
            #line default
            #line hidden
            
            #line 55 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(".IsValid)\r\n        {\r\n            result = result.MergeChildContext(oneOfResult");
            
            #line default
            #line hidden
            
            #line 57 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( oneOfIndex ));
            
            #line default
            #line hidden
            
            #line 57 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(", level >= ValidationLevel.Verbose);\r\n            oneOfCount += 1;\r\n");
            
            #line default
            #line hidden
            
            #line 59 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
      if (!HasUnevaluatedItems && !HasUnevaluatedProperties)
        { 
            
            #line default
            #line hidden
            
            #line 61 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write("            if (oneOfCount > 1 && level == ValidationLevel.Flag)\r\n            {\r\n" +
                    "                result = result.WithResult(isValid: false);\r\n                ret" +
                    "urn result;\r\n            }\r\n");
            
            #line default
            #line hidden
            
            #line 66 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
      } 
            
            #line default
            #line hidden
            
            #line 67 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write("        }\r\n        else\r\n        {\r\n            if (level >= ValidationLevel.Verb" +
                    "ose)\r\n            {\r\n                result = result.MergeResults(result.IsValid" +
                    ", level, oneOfResult");
            
            #line default
            #line hidden
            
            #line 72 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( oneOfIndex ));
            
            #line default
            #line hidden
            
            #line 72 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write(");\r\n            }\r\n        }\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 76 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
      oneOfIndex++;
    } 
            
            #line default
            #line hidden
            
            #line 78 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
            this.Write("\r\n        if (oneOfCount == 1)\r\n        {\r\n            if (level >= ValidationLev" +
                    "el.Verbose)\r\n            {\r\n                result = result.WithResult(isValid: " +
                    "true, \"Validation 10.2.1.3. onef - validated against the oneOf schema.\");\r\n     " +
                    "       }\r\n        }\r\n        else if (oneOfCount == 0)\r\n        {\r\n            i" +
                    "f (level >= ValidationLevel.Detailed)\r\n            {\r\n                result = r" +
                    "esult.WithResult(isValid: false, \"Validation 10.2.1.3. oneOf - failed to validat" +
                    "e against any of the oneOf schema.\");\r\n            }\r\n            else if (level" +
                    " >= ValidationLevel.Basic)\r\n            {\r\n                result = result.WithR" +
                    "esult(isValid: false, \"Validation 10.2.1.3. oneOf - failed to validate against a" +
                    "ny of the oneOf schema.\");\r\n            }\r\n            else\r\n            {\r\n    " +
                    "            result = result.WithResult(isValid: false);\r\n            }\r\n        " +
                    "}\r\n        else\r\n        {\r\n            if (level >= ValidationLevel.Detailed)\r\n" +
                    "            {\r\n                result = result.WithResult(isValid: false, \"Valid" +
                    "ation 10.2.1.3. oneOf - validated against more than one of the oneOf schema.\");\r" +
                    "\n            }\r\n            else if (level >= ValidationLevel.Basic)\r\n          " +
                    "  {\r\n                result = result.WithResult(isValid: false, \"Validation 10.2" +
                    ".1.3. oneOf - failed to validate against more than one of the oneOf schema.\");\r\n" +
                    "            }\r\n            else\r\n            {\r\n                result = result." +
                    "WithResult(isValid: false);\r\n            }\r\n        }\r\n\r\n        if (level > Val" +
                    "idationLevel.Basic)\r\n        {\r\n            result = result.PopLocation(); // on" +
                    "eOf\r\n        }\r\n\r\n        return result;\r\n    }\r\n}\r\n");
            
            #line default
            #line hidden
            
            #line 125 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Validate.OneOf.tt"
 EndNesting(); 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CodeGeneratorValidateOneOfBase {
        
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
