﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Profile.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.Profile.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to AccountId must be provided to use an AccessToken credential..
        /// </summary>
        internal static string AccessTokenRequiresAccount {
            get {
                return ResourceManager.GetString("AccessTokenRequiresAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Account ID &apos;{0}&apos; for tenant &apos;{1}&apos; does not match home Account ID &apos;{2}&apos;.
        /// </summary>
        internal static string AccountIdMismatch {
            get {
                return ResourceManager.GetString("AccountIdMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access token credentials must provide the AccountId parameter..
        /// </summary>
        internal static string AccountIdRequired {
            get {
                return ResourceManager.GetString("AccountIdRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Selected profile must not be null..
        /// </summary>
        internal static string AzureProfileMustNotBeNull {
            get {
                return ResourceManager.GetString("AzureProfileMustNotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please provide either a subscription ID or a subscription name..
        /// </summary>
        internal static string BothSubscriptionIdAndNameProvided {
            get {
                return ResourceManager.GetString("BothSubscriptionIdAndNameProvided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to set default context &apos;{0}&apos;..
        /// </summary>
        internal static string CannotSetDefaultContext {
            get {
                return ResourceManager.GetString("CannotSetDefaultContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Switching targeted subscription in the context to &apos;{0}&apos;.
        /// </summary>
        internal static string ChangingContextSubscription {
            get {
                return ResourceManager.GetString("ChangingContextSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Switching targeted tenant in the context to &apos;{0}&apos;.
        /// </summary>
        internal static string ChangingContextTenant {
            get {
                return ResourceManager.GetString("ChangingContextTenant", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set current context using tenant: &apos;{0}&apos;, subscription: &apos;{1}&apos;.
        /// </summary>
        internal static string ChangingContextUsingPipeline {
            get {
                return ResourceManager.GetString("ChangingContextUsingPipeline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not authenticate your user account {0} with the common tenant. Please login again using Login-AzureRmAccount..
        /// </summary>
        internal static string CommonTenantAuthFailed {
            get {
                return ResourceManager.GetString("CommonTenantAuthFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Context cannot be null.  Please log in using Add-AzureRmAccount..
        /// </summary>
        internal static string ContextCannotBeNull {
            get {
                return ResourceManager.GetString("ContextCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Targeting all subsequent cmdlets at a different tenant and subscription.
        /// </summary>
        internal static string ContextChangeWarning {
            get {
                return ResourceManager.GetString("ContextChangeWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Context &apos;{0}&apos;.
        /// </summary>
        internal static string ContextNameTarget {
            get {
                return ResourceManager.GetString("ContextNameTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No autosave setting detected in variable {0}.  Using default autosave setting (autosave enabled)..
        /// </summary>
        internal static string CouldNotRetrieveAutosaveSetting {
            get {
                return ResourceManager.GetString("CouldNotRetrieveAutosaveSetting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Current tenant with Id &apos;{0}&apos; will be used..
        /// </summary>
        internal static string CurrentTenantInUse {
            get {
                return ResourceManager.GetString("CurrentTenantInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data collection will be disabled permanently for the current user.
        /// </summary>
        internal static string DataCollectionDisabledWarning {
            get {
                return ResourceManager.GetString("DataCollectionDisabledWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cmdlets will send data to Microsoft to help improve the customer experience.
        /// </summary>
        internal static string DataCollectionEnabledWarning {
            get {
                return ResourceManager.GetString("DataCollectionEnabledWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Turn off data collection for Azure PowerShell cmdlets.
        /// </summary>
        internal static string DisableDataCollection {
            get {
                return ResourceManager.GetString("DisableDataCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Allow Azure PowerShell cmdlets to send data to Microsoft to improve the customer experience.
        /// </summary>
        internal static string EnableDataCollection {
            get {
                return ResourceManager.GetString("EnableDataCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to retrieve variable value &apos;{0}&apos; to determine AutoSaveSetting, received exception &apos;{1}&apos; setting AutoSave to true..
        /// </summary>
        internal static string ErrorRetrievingAutosaveSetting {
            get {
                return ResourceManager.GetString("ErrorRetrievingAutosaveSetting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find file &apos;{0}&apos;.
        /// </summary>
        internal static string FileNotFound {
            get {
                return ResourceManager.GetString("FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overwrite File?.
        /// </summary>
        internal static string FileOverwriteCaption {
            get {
                return ResourceManager.GetString("FileOverwriteCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overwrite existing file at &apos;{0}&apos;?.
        /// </summary>
        internal static string FileOverwriteMessage {
            get {
                return ResourceManager.GetString("FileOverwriteMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Current context.
        /// </summary>
        internal static string ImportContextTarget {
            get {
                return ResourceManager.GetString("ImportContextTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided subscription ID &quot;{0}&quot; is not a valid Guid..
        /// </summary>
        internal static string InvalidSubscriptionId {
            get {
                return ResourceManager.GetString("InvalidSubscriptionId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} account in environment &apos;{1}&apos;.
        /// </summary>
        internal static string LoginTarget {
            get {
                return ResourceManager.GetString("LoginTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (no account provided).
        /// </summary>
        internal static string NoAccountProvided {
            get {
                return ResourceManager.GetString("NoAccountProvided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please provide a valid tenant Id on the command line or execute Login-AzureRmAccount..
        /// </summary>
        internal static string NoValidTenant {
            get {
                return ResourceManager.GetString("NoValidTenant", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overwrite context &apos;{0}&apos; with context &apos;{1}&apos;.
        /// </summary>
        internal static string OverwriteContextWarning {
            get {
                return ResourceManager.GetString("OverwriteContextWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set the target account, tenant, and subscription of cmdlets executed in this session to the context stored in {0}.
        /// </summary>
        internal static string ProcessImportContextFromFile {
            get {
                return ResourceManager.GetString("ProcessImportContextFromFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set the target account, tenant, and subscription of cmdlets executed in this session to the provided context.
        /// </summary>
        internal static string ProcessImportContextFromObject {
            get {
                return ResourceManager.GetString("ProcessImportContextFromObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The profile argument was saved to the file system at &apos;{0}&apos;. This file may include personally identifiable information and secrets.  Please ensure that the saved file is assigned appropriate access controls..
        /// </summary>
        internal static string ProfileArgumentSaved {
            get {
                return ResourceManager.GetString("ProfileArgumentSaved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to save the profile argument to the file system at &apos;{0}&apos;.
        /// </summary>
        internal static string ProfileArgumentWrite {
            get {
                return ResourceManager.GetString("ProfileArgumentWrite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current profile was saved to the file system at &apos;{0}&apos;. This file may include personally identifiable information and secrets.  Please ensure that the saved file is assigned appropriate access controls..
        /// </summary>
        internal static string ProfileCurrentSaved {
            get {
                return ResourceManager.GetString("ProfileCurrentSaved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to save the current profile to the file system at &apos;{0}&apos;.
        /// </summary>
        internal static string ProfileCurrentWrite {
            get {
                return ResourceManager.GetString("ProfileCurrentWrite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Personally identifiable information and secrets may be written to the file at &apos;{0}&apos;.  Please ensure that the saved file is assigned appropriate access controls.
        /// </summary>
        internal static string ProfileWriteWarning {
            get {
                return ResourceManager.GetString("ProfileWriteWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove context &apos;{0}&apos;.
        /// </summary>
        internal static string RemoveContextMessage {
            get {
                return ResourceManager.GetString("RemoveContextMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Context.
        /// </summary>
        internal static string RemoveContextTarget {
            get {
                return ResourceManager.GetString("RemoveContextTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Default Context.
        /// </summary>
        internal static string RemoveDefaultContextCaption {
            get {
                return ResourceManager.GetString("RemoveDefaultContextCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is the default context used for communicating with Azure.  Are you sure you want to remove the default context?.
        /// </summary>
        internal static string RemoveDefaultContextQuery {
            get {
                return ResourceManager.GetString("RemoveDefaultContextQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rename context &apos;{0}&apos; to &apos;{1}&apos;.
        /// </summary>
        internal static string RenameContextMessage {
            get {
                return ResourceManager.GetString("RenameContextMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overwrite existing context &apos;{0}&apos;.
        /// </summary>
        internal static string ReplaceContextCaption {
            get {
                return ResourceManager.GetString("ReplaceContextCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to replace existing context &apos;{0}&apos;?.
        /// </summary>
        internal static string ReplaceContextQuery {
            get {
                return ResourceManager.GetString("ReplaceContextQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Resource Manager context was not properly initialized.  Please load the module again..
        /// </summary>
        internal static string RmProfileNull {
            get {
                return ResourceManager.GetString("RmProfileNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change the current context.
        /// </summary>
        internal static string SelectContextPrompt {
            get {
                return ResourceManager.GetString("SelectContextPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Selected subscription is in &apos;{0}&apos; state. .
        /// </summary>
        internal static string SelectedSubscriptionNotActive {
            get {
                return ResourceManager.GetString("SelectedSubscriptionNotActive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter your email if you are interested in providing follow up information:.
        /// </summary>
        internal static string SendFeedbackEmailQuestion {
            get {
                return ResourceManager.GetString("SendFeedbackEmailQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Upon what could Azure PowerShell improve? .
        /// </summary>
        internal static string SendFeedbackNegativeCommentsQuestion {
            get {
                return ResourceManager.GetString("SendFeedbackNegativeCommentsQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} must be issued in interactive mode..
        /// </summary>
        internal static string SendFeedbackNonInteractiveMessage {
            get {
                return ResourceManager.GetString("SendFeedbackNonInteractiveMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value entered was either not convertible to an integer or out of range [0, 10]..
        /// </summary>
        internal static string SendFeedbackOutOfRangeMessage {
            get {
                return ResourceManager.GetString("SendFeedbackOutOfRangeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to What does Azure PowerShell do well?.
        /// </summary>
        internal static string SendFeedbackPositiveCommentsQuestion {
            get {
                return ResourceManager.GetString("SendFeedbackPositiveCommentsQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to With zero (0) being the least and ten (10) being the most, how likely are you to recommend Azure PowerShell to a friend or colleague?.
        /// </summary>
        internal static string SendFeedbackRecommendationQuestion {
            get {
                return ResourceManager.GetString("SendFeedbackRecommendationQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setting property &apos;{0}&apos;=&apos;{1}&apos;.
        /// </summary>
        internal static string SetPropertyAction {
            get {
                return ResourceManager.GetString("SetPropertyAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Targeting all subsequent cmdlets in this session at a different subscription.
        /// </summary>
        internal static string SubscriptionChangeWarning {
            get {
                return ResourceManager.GetString("SubscriptionChangeWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find subscription with name &apos;{0}&apos;..
        /// </summary>
        internal static string SubscriptionNameNotFoundError {
            get {
                return ResourceManager.GetString("SubscriptionNameNotFoundError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provided subscription &apos;{0}&apos; does not exist..
        /// </summary>
        internal static string SubscriptionNameOrIdNotFound {
            get {
                return ResourceManager.GetString("SubscriptionNameOrIdNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subscription {0} was not found in tenant {1}. Please verify that the subscription exists in this tenant..
        /// </summary>
        internal static string SubscriptionNotFoundError {
            get {
                return ResourceManager.GetString("SubscriptionNotFoundError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please provide a valid tenant or a valid subscription..
        /// </summary>
        internal static string SubscriptionOrTenantRequired {
            get {
                return ResourceManager.GetString("SubscriptionOrTenantRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not authenticate with tenant {0}. Please ensure that your account has access to this tenant and log in with Login-AzureRmAccount.
        /// </summary>
        internal static string TenantAuthFailed {
            get {
                return ResourceManager.GetString("TenantAuthFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Targeting all subsequent cmdlets in this session at a different tenant.
        /// </summary>
        internal static string TenantChangeWarning {
            get {
                return ResourceManager.GetString("TenantChangeWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find tenant &apos;{0}&apos;..
        /// </summary>
        internal static string TenantIdNotFound {
            get {
                return ResourceManager.GetString("TenantIdNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To create an access token credential, you must provide an access token account..
        /// </summary>
        internal static string TypeNotAccessToken {
            get {
                return ResourceManager.GetString("TypeNotAccessToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to acquire token for tenant &apos;{0}&apos;.
        /// </summary>
        internal static string UnableToAqcuireToken {
            get {
                return ResourceManager.GetString("UnableToAqcuireToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not authenticate user account &apos;{0}&apos; with tenant &apos;{1}&apos;. Subscriptions in this tenant will not be listed. Please login again using Login-AzureRmAccount to view the subscriptions in this tenant..
        /// </summary>
        internal static string UnableToLogin {
            get {
                return ResourceManager.GetString("UnableToLogin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find environment with name &apos;{0}&apos;.
        /// </summary>
        internal static string UnknownEnvironment {
            get {
                return ResourceManager.GetString("UnknownEnvironment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using autosave setting from session variable &apos;{0}&apos;=&apos;{1}&apos;..
        /// </summary>
        internal static string UsingAutoSaveSettins {
            get {
                return ResourceManager.GetString("UsingAutoSaveSettins", resourceCulture);
            }
        }
    }
}
