﻿namespace Cmf.CustomerPortal.Sdk.Common
{
    public class Resources
    {
        public const string LOGIN_PAT_HELP = "Personal Access Token used to access the Customer Portal";

        public const string DEPLOYMENT_NAME_HELP = "Name of the new Customer Environment. --name is also supported";
        public const string DEPLOYMENT_ALIAS_HELP = "Command Alias";
        public const string DEPLOYMENT_DESCRIPTION_HELP = "Description of the new Customer Environment";
        public const string DEPLOYMENT_PARAMETERSPATH_HELP = "Path to parameters file that describes the Customer Environment";
        public const string DEPLOYMENT_ENVIRONMENTTYPE_HELP = "Type of the Customer Environment to deploy";
        public const string DEPLOYMENT_SITE_HELP = "Name of the Site associated with the Customer Environment";
        public const string DEPLOYMENT_LICENSE_HELP = "Name of the License to use for the Customer Environment";
        public const string DEPLOYMENT_PACKAGE_HELP = "Name of the Deployment Package to use for the Customer Environment";
        public const string DEPLOYMENT_TARGET_HELP = "Name of the Deployment Target to use for the Customer Environment";
        public const string DEPLOYMENT_OUTPUTDIR_HELP = "Directory to place any artifacts generated by the deployment";
        public const string DEPLOYMENT_INTERACTIVE_HELP = "Flag that controls if the user should be prompted to go to the portal to initialize the installation manually";
        public const string DEPLOYMENT_TERMINATE_OTHER_VERSIONS_HELP = "Flag that controls if all the other versions of the Customer Environment should be terminated";
        public const string DEPLOYMENT_TIMEOUT_MINUTES = "Number of minutes that are allowed to wait for the deployment to succeed. The default is 60 minutes.";
        public const string DEPLOYMENT_TERMINATE_OTHER_VERSIONS_REMOVE_HELP = "Flag that controls if the deployments of the versions of the Customer Environment that will be terminated should be removed. Requires the terminateOtherVersions flag.";
        public const string DEPLOYMENT_TERMINATE_OTHER_VERSIONS_REMOVE_VOLUMES_HELP = "Flag that controls if the volumes of the versions of the Customer Environment that will be terminated should be removed. Requires the terminateOtherVersions and terminateOtherVersionsRemove flags.";
        public const string APP_NAME_HELP = "The name of the App to install.";
        public const string APP_VERSION_HELP = "The version of the App to install.";
        public const string APP_CUSTOMER_ENVIRONMENT_HELP = "The name of a Convergence Customer Environment to install the App on.";
        public const string APP_LICENSE_HELP = "Name of the License to use for the App.";
        public const string APP_INSTALLATION_TIMEOUT = "Timeout, in minutes, to wait for an App to install. The default is 60 minutes.";
        public const string APP_PARAMETERS_PATH_HELP = "Path to parameters file that describes the App in a Convergence Customer Environment.";
        public const string INFRASTRUCTURE_NAME_HELP = "The name of the Customer Infrastructure to be created";
        public const string INFRASTRUCTURE_SITE_HELP = "(deprecated) Name of a Site used to match a Customer with the Customer Infrastructure";
        public const string INFRASTRUCTURE_CUSTOMER_HELP = "Name of the Customer associated with the Customer Infrastructure";
        public const string INFRASTRUCTURE_EXISTING_NAME_HELP = "Name of the existing Customer Infrastructure";
        public const string INFRASTRUCTURE_IGNORE_IF_EXISTS_HELP = "Flag that ignores a throw if an error of type 'Customer Infrastructure already exist' occurs";
        public const string INFRASTRUCTURE_PARAMETERSPATH_HELP = "Path to parameters json file that includes parameters for the Customer Infrastructure";

        public const string GETAGENTCONNECTION_NAME_HELP = "The name of the Infrastructure Agent";

        public const string PUBLISHMANIFESTS_PATH_HELP = "Path to Deployment Package Manifest file, or folder to a folder containing multiple manifest files";
        public const string PUBLISHMANIFESTS_DATAGROUP_HELP = "Name of the datagroup to assign to the published deployment packages";

        public const string PUBLISHPACKAGE_PATH_HELP = "Path to Package zip file";
        public const string PUBLISHPACKAGE_DATAGROUP_HELP = "Name of the datagroup to assign to the published packages";

        public const string REPLACETOKENS_HELP = "Replace the tokens specified in the input files using the proper syntax (e.g. #{MyToken}#) with the specified values. E.g. MyToken=value MyToken2=value2.";

        public const string VERBOSE_HELP = "Show detailed logging";
    }
}
