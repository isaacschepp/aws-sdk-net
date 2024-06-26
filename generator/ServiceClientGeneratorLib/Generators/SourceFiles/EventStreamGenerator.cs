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
    
    #line 1 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class EventStreamGenerator : StructureGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"

    bool isRequest = this.Operation.RequestStructure.Members.Any(x => x.ModelShape.MarshallName == this.Structure.Name);
    bool isResponse = this.Operation.ResponseStructure.Members.Any(x => x.ModelShape.MarshallName == this.Structure.Name);

            
            #line default
            #line hidden
            this.Write("    [System.Diagnostics.CodeAnalysis.SuppressMessage(\"Naming\", \"CA1710:Identifier" +
                    "s should have correct suffix\", Justification = \"");
            
            #line 10 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write(@"Collection is not descriptive"")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage(""Microsoft.Design"", ""CA1063"", Justification = ""IDisposable is a transient interface from IEventStream. Users need to be able to call Dispose."")]
    public sealed class ");
            
            #line 12 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write(" : EnumerableEventStream<IEventStreamEvent, ");
            
            #line 12 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write(@"EventStreamException>
    {
        /// <summary>
        ///The mapping of event message to a generator function to construct the matching EventStream event
        /// </summary>
        protected override IDictionary<string,Func<IEventStreamMessage, IEventStreamEvent>> EventMapping {get;} =
        new Dictionary<string,Func<IEventStreamMessage,IEventStreamEvent>>(StringComparer.OrdinalIgnoreCase)
        {
");
            
            #line 20 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"

        string protocol = null;
        if (string.Equals(this.Config.ServiceModel.Protocol,"rest-json", StringComparison.OrdinalIgnoreCase) || string.Equals(this.Config.ServiceModel.Protocol,"json", StringComparison.OrdinalIgnoreCase))
            protocol = "Json";
        else if(string.Equals(this.Config.ServiceModel.Protocol,"rest-xml",StringComparison.OrdinalIgnoreCase))
            protocol = "Xml";
        else
        {
            throw new NotSupportedException("The given protocol is not supported or has not been implemented yet");
        }

            
            #line default
            #line hidden
            
            #line 31 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"

        if(isResponse)
        {

            
            #line default
            #line hidden
            this.Write("            {\"Initial-Response\", payload => new InitialResponseEvent(payload)},\r\n" +
                    "");
            
            #line 36 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"

        }

            
            #line default
            #line hidden
            
            #line 39 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"

        else if(isRequest)
        {

            
            #line default
            #line hidden
            this.Write("            {\"Initial-Request\", payload => new InitialRequestEvent(payload)},\r\n");
            
            #line 44 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"

        }

            
            #line default
            #line hidden
            
            #line 47 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"

        foreach(var member in this.Structure.Members)
        {
        if(member.ModelShape.IsEvent)
            {

            
            #line default
            #line hidden
            this.Write("            {\"");
            
            #line 53 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write("\", payload => new ");
            
            #line 53 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DetermineType()));
            
            #line default
            #line hidden
            this.Write("Unmarshaller().Unmarshall(EventStreamUtils.ConvertMessageTo");
            
            #line 53 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(protocol));
            
            #line default
            #line hidden
            this.Write("Context(payload))},\r\n");
            
            #line 54 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"

            }
        }

            
            #line default
            #line hidden
            this.Write("        };\r\n        /// <summary>\r\n        /// The mapping of event message to a " +
                    "generator function to construct the matching EventStream Exception\r\n        /// " +
                    "</summary>\r\n        protected override IDictionary<string,Func<IEventStreamMessa" +
                    "ge,");
            
            #line 62 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write("EventStreamException>> ExceptionMapping {get;} =\r\n        new Dictionary<string,F" +
                    "unc<IEventStreamMessage,");
            
            #line 63 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write("EventStreamException>>(StringComparer.OrdinalIgnoreCase)\r\n        {\r\n");
            
            #line 65 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"

        foreach(var member in this.Structure.Members)
        {
            if(member.ModelShape.IsException)
            {

            
            #line default
            #line hidden
            this.Write("            { \"");
            
            #line 71 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write("\", payload => new ");
            
            #line 71 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write("EventStreamException(Encoding.UTF8.GetString(payload.Payload), new ");
            
            #line 71 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.ModelShape));
            
            #line default
            #line hidden
            this.Write("Unmarshaller().Unmarshall(EventStreamUtils.ConvertMessageTo");
            
            #line 71 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(protocol));
            
            #line default
            #line hidden
            this.Write("Context(payload))) },\r\n");
            
            #line 72 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"

            }
        }

            
            #line default
            #line hidden
            this.Write(@"        };
        // Backing by a volatile bool. The flag only changes one way, so no need for a lock.
        // This is located in the subclass to be CLS compliant.
        private volatile bool _isProcessing;

        /// <summary>
        /// Whether the backround processing loop is running.
        /// </summary>
        protected override bool IsProcessing
        {
            get { return _isProcessing; }
            set { _isProcessing = value; }
        }

        /// <summary>
        /// Event that encompasses all events.
        /// </summary>
        public override event EventHandler<EventStreamEventReceivedArgs<IEventStreamEvent>> EventReceived;

        /// <summary>
        /// Event that encompasses exceptions.
        /// </summary>
        public override event EventHandler<EventStreamExceptionReceivedArgs<");
            
            #line 98 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ClassName));
            
            #line default
            #line hidden
            this.Write("EventStreamException>> ExceptionReceived;\r\n");
            
            #line 99 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"

        if(isResponse)
        {

            
            #line default
            #line hidden
            this.Write("        /// <summary>\r\n        /// Event for the initial response.\r\n        /// <" +
                    "/summary>\r\n        public event EventHandler<EventStreamEventReceivedArgs<Initia" +
                    "lResponseEvent>> InitialResponseReceived;\r\n");
            
            #line 107 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"

        }
        else if(isRequest)
        {

            
            #line default
            #line hidden
            this.Write("        /// <summary>\r\n        /// Event for the initial request.\r\n        /// </" +
                    "summary>\r\n        public event EventHandler<EventStreamEventReceivedArgs<Initial" +
                    "RequestEvent>> InitialRequestReceived;\r\n");
            
            #line 116 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"

        }

            
            #line default
            #line hidden
            
            #line 119 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"

        foreach(var member in this.Structure.Members)
        {
            if(member.ModelShape.IsEvent)
            {

            
            #line default
            #line hidden
            this.Write("        ///<summary>\r\n        ///Raised when an ");
            
            #line 126 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write(" event is received\r\n        ///</summary>\r\n        public event EventHandler<Even" +
                    "tStreamEventReceivedArgs<");
            
            #line 128 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DetermineType()));
            
            #line default
            #line hidden
            this.Write(">> ");
            
            #line 128 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write("Received;\r\n");
            
            #line 129 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"

            }

            
            #line default
            #line hidden
            
            #line 132 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"

        }

            
            #line default
            #line hidden
            this.Write("\r\n        /// <summary>\r\n        /// Construct an instance\r\n        /// </summary" +
                    ">\r\n        /// <param name=\"stream\"></param>        \r\n        public ");
            
            #line 140 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write(@"(Stream stream) : this (stream, null)
        {
        }

        /// <summary>
        /// Construct an instance
        /// </summary>
        /// <param name=""stream""></param>
        /// <param name=""eventStreamDecoder""></param>
        public ");
            
            #line 149 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write(@"(Stream stream, IEventStreamDecoder eventStreamDecoder) : base(stream, eventStreamDecoder)
        {
            base.EventReceived += (sender,args) => EventReceived?.Invoke(this, args);
            base.ExceptionReceived += (sender,args) => ExceptionReceived?.Invoke(this, args);

            //Mapping the generic Event to more specific Events
            Decoder.MessageReceived += (sender, args) =>
            {
                IEventStreamEvent ev;
                try
                {
                    ev = ConvertMessageToEvent(args.Message);
                }
                catch(UnknownEventStreamException)
                {
                    throw new UnknownEventStreamException(""Received an unknown event stream type"");
                }
                EventReceived?.Invoke(this, new EventStreamEventReceivedArgs<IEventStreamEvent>(ev));

                //Call RaiseEvent until it returns true or all calls complete. This way only a subset of casts are perfromed
                // and we can avoid a cascade of nested if else statements. The result is thrown away
                var _ =
");
            
            #line 171 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"

                if(isResponse)

            
            #line default
            #line hidden
            this.Write("                    RaiseEvent(InitialResponseReceived, ev) ||\r\n");
            
            #line 175 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"

                else if(isRequest)

            
            #line default
            #line hidden
            this.Write("                    RaiseEvent(InitialRequestReceived,ev) ||\r\n");
            
            #line 179 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"


                var eventMembers = this.Structure.Members.Where(m => m.ModelShape.IsEvent).ToArray();
                if(eventMembers.Length == 1)
                {

            
            #line default
            #line hidden
            this.Write("                    RaiseEvent(");
            
            #line 185 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(eventMembers[0].PropertyName));
            
            #line default
            #line hidden
            this.Write("Received,ev);\r\n");
            
            #line 186 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"

                }
                else if (eventMembers.Length > 1)
                {
                    for(int i = 0; i < eventMembers.Length - 1; i++)
                    {

            
            #line default
            #line hidden
            this.Write("                    RaiseEvent(");
            
            #line 193 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(eventMembers[i].PropertyName));
            
            #line default
            #line hidden
            this.Write("Received,ev) ||\r\n");
            
            #line 194 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"

                    }

            
            #line default
            #line hidden
            this.Write("                    RaiseEvent(");
            
            #line 197 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(eventMembers.Last().PropertyName));
            
            #line default
            #line hidden
            this.Write("Received,ev);\r\n");
            
            #line 198 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\EventStreamGenerator.tt"

                }

            
            #line default
            #line hidden
            this.Write(@"            };       
        }
        private bool RaiseEvent<T>(EventHandler<EventStreamEventReceivedArgs<T>> eventHandler, IEventStreamEvent ev) where T : class, IEventStreamEvent
        {
            var convertedEvent = ev as T;
            if (convertedEvent != null)
            {
                eventHandler?.Invoke(this, new EventStreamEventReceivedArgs<T>(convertedEvent));
                return true;
            }

            return false;
        }
");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
