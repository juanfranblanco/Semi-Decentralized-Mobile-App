﻿// <auto-generated />
using System;
using System.Net.Http;
using System.Collections.Generic;
using HealthCareMobileApp.RefitInternalGenerated;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

#pragma warning disable
namespace HealthCareMobileApp.RefitInternalGenerated
{
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {

        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}
#pragma warning restore

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning disable CS8669 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. Auto-generated code requires an explicit '#nullable' directive in source.
namespace HealthCareMobileApp.WebInterface
{
    using global::HealthCareMobileApp.Contracts;
    using global::Refit;
    using global::System.Collections.Generic;
    using global::System.Threading.Tasks;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedIHealthCareAPI : IHealthCareAPI
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedIHealthCareAPI(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<List<Prescription>> IHealthCareAPI.GetPrescriptions(string id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetPrescriptions", new Type[] { typeof(string) });
            return (Task<List<Prescription>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Patient> IHealthCareAPI.GetPatientFile(string id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetPatientFile", new Type[] { typeof(string) });
            return (Task<Patient>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<Modification>> IHealthCareAPI.GetModifications(string id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetModifications", new Type[] { typeof(string) });
            return (Task<List<Modification>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<string> IHealthCareAPI.Respond(Modification modification)
        {
            var arguments = new object[] { modification };
            var func = requestBuilder.BuildRestResultFuncForMethod("Respond", new Type[] { typeof(Modification) });
            return (Task<string>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<string> IHealthCareAPI.DeleteModification(int id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("DeleteModification", new Type[] { typeof(int) });
            return (Task<string>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<string> IHealthCareAPI.SubmitModification(Modification modification)
        {
            var arguments = new object[] { modification };
            var func = requestBuilder.BuildRestResultFuncForMethod("SubmitModification", new Type[] { typeof(Modification) });
            return (Task<string>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<string> IHealthCareAPI.UpdatePatientFile(string id, Patient value)
        {
            var arguments = new object[] { id, value };
            var func = requestBuilder.BuildRestResultFuncForMethod("UpdatePatientFile", new Type[] { typeof(string), typeof(Patient) });
            return (Task<string>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<bool> IHealthCareAPI.IsDoctor(string id)
        {
            var arguments = new object[] { id };
            var func = requestBuilder.BuildRestResultFuncForMethod("IsDoctor", new Type[] { typeof(string) });
            return (Task<bool>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Drug> IHealthCareAPI.GetDrug(string name)
        {
            var arguments = new object[] { name };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetDrug", new Type[] { typeof(string) });
            return (Task<Drug>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<string> IHealthCareAPI.CreatePrescription(Prescription prescription)
        {
            var arguments = new object[] { prescription };
            var func = requestBuilder.BuildRestResultFuncForMethod("CreatePrescription", new Type[] { typeof(Prescription) });
            return (Task<string>)func(Client, arguments);
        }
    }
}

#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning restore CS8669 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. Auto-generated code requires an explicit '#nullable' directive in source.
