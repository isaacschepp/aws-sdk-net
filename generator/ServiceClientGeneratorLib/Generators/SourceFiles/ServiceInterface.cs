﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.SourceFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class ServiceInterface : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("\r\n\r\nusing System;\r\nusing System.Collections.Generic;\r\n\r\nusing Amazon.Runtime;\r\nus" +
                    "ing ");
            
            #line 15 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model;\r\n\r\n#pragma warning disable CS1570\r\nnamespace ");
            
            #line 18 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n");
            
            #line 20 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
    this.FormatServiceInterfaceDocumentation(this.Config.ServiceModel.Documentation); 
            
            #line default
            #line hidden
            this.Write("\tpublic partial interface IAmazon");
            
            #line 21 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write(" : IAmazonService, IDisposable\r\n\t{\r\n\r\n\r\n");
            
            #line 25 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

    // Creates paginators for service if available
    if (this.Config.ServiceModel.HasPaginators)
    {

            
            #line default
            #line hidden
            this.Write("#if BCL45 || AWS_ASYNC_ENUMERABLES_API\r\n        /// <summary>\r\n        /// Pagina" +
                    "tors for the service\r\n        /// </summary>\r\n        I");
            
            #line 34 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceNameRoot));
            
            #line default
            #line hidden
            this.Write("PaginatorFactory Paginators { get; }\r\n#endif\r\n");
            
            #line 36 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

    }

            
            #line default
            #line hidden
            this.Write("\r\n\r\n\t\t");
            
            #line 41 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

		foreach(var operation in this.Config.ServiceModel.Operations)
		{
            if(operation.IsInternal)
                continue;
		
            
            #line default
            #line hidden
            this.Write("\r\n\t\t#region  ");
            
            #line 48 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            
            #line 50 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

        // Creates a method for the operation that takes no parameters if the operation has a request that requires no members to be set
        if (this.Config.ServiceModel.Customizations.CreateNoArgOverload(operation.Name))
        {

            
            #line default
            #line hidden
            
            #line 55 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

        this.FormatOperationDocumentationSync(operation, false);
		if(operation.IsDeprecated)
		{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 60 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 61 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
		
		}

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 64 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response ");
            
            #line 64 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("();\r\n");
            
            #line 65 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

        }

        AddSimpleClientMethodInterfaces(operation, true);

            
            #line default
            #line hidden
            
            #line 70 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

        this.FormatOperationDocumentationSync(operation, true);
		if(operation.IsDeprecated)
		{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 75 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 76 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
		
		}

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 79 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response ");
            
            #line 79 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 79 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request request);\r\n\r\n");
            
            #line 81 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
AddBeginAsyncDocumentation(operation);
		if(operation.IsDeprecated)
		{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 85 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 86 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
		
		}

            
            #line default
            #line hidden
            this.Write("        IAsyncResult Begin");
            
            #line 89 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 89 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request request, AsyncCallback callback, object state);\r\n\r\n\r\n\r\n");
            
            #line 93 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
AddEndAsyncDocumentation(operation);
		if(operation.IsDeprecated)
		{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 97 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 98 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
		
		}

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 101 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response End");
            
            #line 101 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(IAsyncResult asyncResult);\r\n\r\n\t\t#endregion\r\n\t\t");
            
            #line 104 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

		}
		
            
            #line default
            #line hidden
            
            #line 107 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
 if (this.Config.EndpointsRuleSet != null) { 
            
            #line default
            #line hidden
            this.Write(@"        
		#region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name=""request"">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion
");
            
            #line 119 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
