using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using TestAutomationProject;

[assembly: WorkflowRunnerServiceAttribute(typeof(TestAutomationProject.WorkflowRunnerService))]
namespace TestAutomationProject
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the CoverageMergeHelperWorkflow.xaml
        /// </summary>
        public void CoverageMergeHelperWorkflow(string PackageId, long TestSetExecutionId)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"CoverageMergeHelperWorkflow.xaml", new Dictionary<string, object> { { "PackageId", PackageId }, { "TestSetExecutionId", TestSetExecutionId } }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the CoverageMergeHelperWorkflow.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void CoverageMergeHelperWorkflow(string PackageId, long TestSetExecutionId, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"CoverageMergeHelperWorkflow.xaml", new Dictionary<string, object> { { "PackageId", PackageId }, { "TestSetExecutionId", TestSetExecutionId } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the TestCase.xaml
        /// </summary>
        public void TestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"TestCase.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the TestCase.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void TestCase(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"TestCase.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the PerformanceTestingBootloaderWorkflow.cs
        /// </summary>
        public void PerformanceTestingBootloaderWorkflow(System.String pipeName, System.String workflowPath, System.Collections.Generic.Dictionary<System.String, System.Object> wfArgs)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"PerformanceTestingBootloaderWorkflow.cs", new Dictionary<string, object> { { "pipeName", pipeName }, { "workflowPath", workflowPath }, { "wfArgs", wfArgs } }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the PerformanceTestingBootloaderWorkflow.cs
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void PerformanceTestingBootloaderWorkflow(System.String pipeName, System.String workflowPath, System.Collections.Generic.Dictionary<System.String, System.Object> wfArgs, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"PerformanceTestingBootloaderWorkflow.cs", new Dictionary<string, object> { { "pipeName", pipeName }, { "workflowPath", workflowPath }, { "wfArgs", wfArgs } }, default, isolated, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}