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
    
    
    public partial class CodeGeneratorConst : CodeGeneratorConstBase {
        
        
        #line 104 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"

    public bool ShouldGenerate
    {
        get
        {
            return HasConst;
        }
    }

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"

    // This is only emitted if HasConst is true
    if(!ShouldGenerate)
    {
        throw new InvalidOperationException("CodeGenerator.Const should not be emitted if HasConst is false.");
    } 
            
            #line default
            #line hidden
            
            #line 10 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
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
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace ");
            
            #line default
            #line hidden
            
            #line 27 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 27 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 29 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 30 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write("/// <summary>\r\n/// A type generated from a JsonSchema specification.\r\n/// </summa" +
                    "ry>\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 33 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 33 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
 if (HasConstNull) { 
            
            #line default
            #line hidden
            
            #line 34 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(" : IJsonValue<");
            
            #line default
            #line hidden
            
            #line 34 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 34 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(">");
            
            #line default
            #line hidden
            
            #line 34 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
 } 
            
            #line default
            #line hidden
            
            #line 35 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write("{\r\n");
            
            #line default
            #line hidden
            
            #line 36 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
  if(HasConstString)
    { 
            
            #line default
            #line hidden
            
            #line 38 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write("    private static readonly ");
            
            #line default
            #line hidden
            
            #line 38 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 38 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(" __CorvusConstValue = ");
            
            #line default
            #line hidden
            
            #line 38 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 38 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(".ParseValue(");
            
            #line default
            #line hidden
            
            #line 38 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( ConstString ));
            
            #line default
            #line hidden
            
            #line 38 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write("u8);\r\n");
            
            #line default
            #line hidden
            
            #line 39 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
  }
    else if(HasConstBoolean)
    { 
            
            #line default
            #line hidden
            
            #line 42 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write("    private static readonly ");
            
            #line default
            #line hidden
            
            #line 42 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 42 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(" __CorvusConstValue = ");
            
            #line default
            #line hidden
            
            #line 42 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 42 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(".ParseValue(");
            
            #line default
            #line hidden
            
            #line 42 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( ConstBoolean ));
            
            #line default
            #line hidden
            
            #line 42 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write("u8);\r\n");
            
            #line default
            #line hidden
            
            #line 43 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
  }
    else if(HasConstNumber)
    { 
            
            #line default
            #line hidden
            
            #line 46 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write("    private static readonly ");
            
            #line default
            #line hidden
            
            #line 46 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 46 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(" __CorvusConstValue = ");
            
            #line default
            #line hidden
            
            #line 46 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 46 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(".ParseValue(");
            
            #line default
            #line hidden
            
            #line 46 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( ConstNumber ));
            
            #line default
            #line hidden
            
            #line 46 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write("u8);\r\n");
            
            #line default
            #line hidden
            
            #line 47 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
  }
    else if(HasConstObject)
    { 
            
            #line default
            #line hidden
            
            #line 50 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write("    private static readonly ");
            
            #line default
            #line hidden
            
            #line 50 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 50 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(" __CorvusConstValue = ");
            
            #line default
            #line hidden
            
            #line 50 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 50 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(".ParseValue(");
            
            #line default
            #line hidden
            
            #line 50 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( ConstObject ));
            
            #line default
            #line hidden
            
            #line 50 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write("u8);\r\n");
            
            #line default
            #line hidden
            
            #line 51 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
  }
    else if(HasConstArray)
    { 
            
            #line default
            #line hidden
            
            #line 54 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write("    private static readonly ");
            
            #line default
            #line hidden
            
            #line 54 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 54 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(" __CorvusConstValue = ");
            
            #line default
            #line hidden
            
            #line 54 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 54 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(".ParseValue(");
            
            #line default
            #line hidden
            
            #line 54 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( ConstArray ));
            
            #line default
            #line hidden
            
            #line 54 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write("u8);\r\n");
            
            #line default
            #line hidden
            
            #line 55 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
  }
    else if(HasConstNull)
    { 
            
            #line default
            #line hidden
            
            #line 58 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write("    private static readonly ");
            
            #line default
            #line hidden
            
            #line 58 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 58 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(" __CorvusConstValue = ");
            
            #line default
            #line hidden
            
            #line 58 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 58 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(".ParseValue(\"null\"u8);\r\n");
            
            #line default
            #line hidden
            
            #line 59 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
  }   
            
            #line default
            #line hidden
            
            #line 60 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write("\r\n    ");
            
            #line default
            #line hidden
            
            #line 61 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
 // Note that if this is a const value, it cannot be of more than one type, so it is safe to initialize
       // Only the single backing value. 
            
            #line default
            #line hidden
            
            #line 63 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write("    /// <summary>\r\n    /// Initializes a new instance of the <see cref=\"");
            
            #line default
            #line hidden
            
            #line 64 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 64 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write("\"/> struct.\r\n    /// </summary>\r\n    public ");
            
            #line default
            #line hidden
            
            #line 66 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 66 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write("()\r\n    {\r\n        this.jsonElementBacking = __CorvusConstValue.jsonElementBackin" +
                    "g;\r\n");
            
            #line default
            #line hidden
            
            #line 69 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
  if(IsImplicitObject)
    {
    
            
            #line default
            #line hidden
            
            #line 72 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write("        this.objectBacking = __CorvusConstValue.objectBacking;\r\n");
            
            #line default
            #line hidden
            
            #line 73 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
  }

    if(IsImplicitArray)
    { 
            
            #line default
            #line hidden
            
            #line 77 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write("        this.arrayBacking = __CorvusConstValue.arrayBacking;\r\n");
            
            #line default
            #line hidden
            
            #line 78 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
  }

    if(IsImplicitNumber)
    { 
            
            #line default
            #line hidden
            
            #line 82 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write("        this.numberBacking = __CorvusConstValue.numberBacking;\r\n");
            
            #line default
            #line hidden
            
            #line 83 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
  }

    if(IsImplicitString)
    { 
            
            #line default
            #line hidden
            
            #line 87 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write("        this.stringBacking = __CorvusConstValue.stringBacking;\r\n");
            
            #line default
            #line hidden
            
            #line 88 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
  }

    if(IsImplicitBoolean)
    { 
            
            #line default
            #line hidden
            
            #line 92 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write("        this.boolBacking = __CorvusConstValue.boolBacking;\r\n");
            
            #line default
            #line hidden
            
            #line 93 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
  } 
            
            #line default
            #line hidden
            
            #line 94 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write("\r\n        this.backing = __CorvusConstValue.backing;\r\n    }\r\n\r\n    /// <summary>\r" +
                    "\n    /// Gets the constant value for this instance\r\n    /// </summary>\r\n    publ" +
                    "ic static ");
            
            #line default
            #line hidden
            
            #line 101 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 101 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
            this.Write(" ConstInstance => __CorvusConstValue;\r\n}\r\n");
            
            #line default
            #line hidden
            
            #line 103 "D:\source\corvus-dotnet\Corvus.JsonSchema\Solutions\Corvus.Json.CodeGeneration.Abstractions\SharedTemplates\CodeGenerator.Const.tt"
 EndNesting(); 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CodeGeneratorConstBase {
        
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
