//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:7.0.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Corvus.Json.CodeGeneration.Generators.Draft7 {
    using System.Collections.Generic;
    using Corvus.Json;
    using System;
    
    
    public partial class CodeGeneratorValidateType : CodeGeneratorValidateTypeBase {
        
        
        #line 150 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"

    public bool ShouldGenerate
    {
        get
        {
            return HasType;
        }
    }

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"

    // This is only emitted if HasType is true
    if(!ShouldGenerate)
    {
        throw new InvalidOperationException("CodeGenerator.Validate.Type should not be emitted if HasType is false.");
    } 
            
            #line default
            #line hidden
            
            #line 10 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(@"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable

using System.Text.Json;
using Corvus.Json;

namespace ");
            
            #line default
            #line hidden
            
            #line 24 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 24 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 26 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 27 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write("/// <summary>\r\n/// A type generated from a JsonSchema specification.\r\n/// </summa" +
                    "ry>\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 30 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 30 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write("\r\n{\r\n    private ValidationContext ValidateType(JsonValueKind valueKind, in Valid" +
                    "ationContext validationContext, ValidationLevel level)\r\n    {\r\n        Validatio" +
                    "nContext result = validationContext;\r\n        bool isValid = false;\r\n");
            
            #line default
            #line hidden
            
            #line 36 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
  if (HasStringType)
    { 
            
            #line default
            #line hidden
            
            #line 38 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(@"
        ValidationContext localResultString = Corvus.Json.Validate.TypeString(valueKind, result.CreateChildContext(), level);
        if (level == ValidationLevel.Flag && localResultString.IsValid)
        {
            return validationContext;
        }

        if (localResultString.IsValid)
        {
            isValid = true;
        }
");
            
            #line default
            #line hidden
            
            #line 49 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
  }
    if (HasObjectType)
    { 
            
            #line default
            #line hidden
            
            #line 52 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(@"
        ValidationContext localResultObject = Corvus.Json.Validate.TypeObject(valueKind, result.CreateChildContext(), level);
        if (level == ValidationLevel.Flag && localResultObject.IsValid)
        {
            return validationContext;
        }

        if (localResultObject.IsValid)
        {
            isValid = true;
        }
");
            
            #line default
            #line hidden
            
            #line 63 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
  }
    if (HasArrayType)
    { 
            
            #line default
            #line hidden
            
            #line 66 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(@"
        ValidationContext localResultArray = Corvus.Json.Validate.TypeArray(valueKind, result.CreateChildContext(), level);
        if (level == ValidationLevel.Flag && localResultArray.IsValid)
        {
            return validationContext;
        }

        if (localResultArray.IsValid)
        {
            isValid = true;
        }
");
            
            #line default
            #line hidden
            
            #line 77 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
  }
    if (HasNumberType)
    { 
            
            #line default
            #line hidden
            
            #line 80 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(@"
        ValidationContext localResultNumber = Corvus.Json.Validate.TypeNumber(valueKind, result.CreateChildContext(), level);
        if (level == ValidationLevel.Flag && localResultNumber.IsValid)
        {
            return validationContext;
        }

        if (localResultNumber.IsValid)
        {
            isValid = true;
        }
");
            
            #line default
            #line hidden
            
            #line 91 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
  }
    if (HasIntegerType)
    { 
            
            #line default
            #line hidden
            
            #line 94 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(@"
        ValidationContext localResultInteger = Corvus.Json.Validate.TypeInteger(this, result.CreateChildContext(), level);
        if (level == ValidationLevel.Flag && localResultInteger.IsValid)
        {
            return validationContext;
        }

        if (localResultInteger.IsValid)
        {
            isValid = true;
        }
");
            
            #line default
            #line hidden
            
            #line 105 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
  }
    if (HasBooleanType)
    { 
            
            #line default
            #line hidden
            
            #line 108 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(@"
        ValidationContext localResultBoolean = Corvus.Json.Validate.TypeBoolean(valueKind, result.CreateChildContext(), level);
        if (level == ValidationLevel.Flag && localResultBoolean.IsValid)
        {
            return validationContext;
        }

        if (localResultBoolean.IsValid)
        {
            isValid = true;
        }
");
            
            #line default
            #line hidden
            
            #line 119 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
  }
    if (HasNullType)
    { 
            
            #line default
            #line hidden
            
            #line 122 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(@"
        ValidationContext localResultNull = Corvus.Json.Validate.TypeNull(valueKind, result.CreateChildContext(), level);
        if (level == ValidationLevel.Flag && localResultNull.IsValid)
        {
            return validationContext;
        }

        if (localResultNull.IsValid)
        {
            isValid = true;
        }
");
            
            #line default
            #line hidden
            
            #line 133 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
  } 
            
            #line default
            #line hidden
            
            #line 134 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write("\r\n        result = result.MergeResults(\r\n            isValid,\r\n            level," +
                    "\r\n");
            
            #line default
            #line hidden
            
            #line 138 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasStringType ? "           localResultString" : "" ));
            
            #line default
            #line hidden
            
            #line 138 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasStringType ? (HasObjectType || HasArrayType || HasNumberType || HasIntegerType || HasBooleanType || HasNullType ? "," : ");") : "" ));
            
            #line default
            #line hidden
            
            #line 138 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write("\r\n");
            
            #line default
            #line hidden
            
            #line 139 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasObjectType ? "           localResultObject" : "" ));
            
            #line default
            #line hidden
            
            #line 139 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasObjectType ? (HasArrayType || HasNumberType || HasIntegerType || HasBooleanType || HasNullType ? "," : ");") : "" ));
            
            #line default
            #line hidden
            
            #line 139 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write("\r\n");
            
            #line default
            #line hidden
            
            #line 140 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasArrayType ? "            localResultArray" : "" ));
            
            #line default
            #line hidden
            
            #line 140 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasArrayType ? (HasNumberType || HasIntegerType || HasBooleanType || HasNullType ? "," : ");") : "" ));
            
            #line default
            #line hidden
            
            #line 140 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write("\r\n");
            
            #line default
            #line hidden
            
            #line 141 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasNumberType ? "           localResultNumber" : "" ));
            
            #line default
            #line hidden
            
            #line 141 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasNumberType ? (HasIntegerType || HasBooleanType || HasNullType ? "," : ");") : "" ));
            
            #line default
            #line hidden
            
            #line 141 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write("\r\n");
            
            #line default
            #line hidden
            
            #line 142 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasIntegerType ? "          localResultInteger" : "" ));
            
            #line default
            #line hidden
            
            #line 142 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasIntegerType ? (HasBooleanType || HasNullType ? "," : ");") : "" ));
            
            #line default
            #line hidden
            
            #line 142 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write("\r\n");
            
            #line default
            #line hidden
            
            #line 143 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasBooleanType ? "          localResultBoolean" : "" ));
            
            #line default
            #line hidden
            
            #line 143 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasBooleanType ? (HasNullType ? "," : ");") : "" ));
            
            #line default
            #line hidden
            
            #line 143 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write("\r\n");
            
            #line default
            #line hidden
            
            #line 144 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( HasNullType ? "         localResultNull);" : "" ));
            
            #line default
            #line hidden
            
            #line 144 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
            this.Write("\r\n\r\n            return result;\r\n        }\r\n}\r\n");
            
            #line default
            #line hidden
            
            #line 149 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.Type.tt"
 EndNesting(); 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CodeGeneratorValidateTypeBase {
        
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
