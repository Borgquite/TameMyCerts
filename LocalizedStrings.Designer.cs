﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TameMyCerts {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class LocalizedStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LocalizedStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TameMyCerts.LocalizedStrings", typeof(LocalizedStrings).Assembly);
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
        ///   Looks up a localized string similar to Unable to parse &quot;{0}&quot; request attribute. The value was &quot;{1}&quot;..
        /// </summary>
        internal static string AttibVal_Err_Parse {
            get {
                return ResourceManager.GetString("AttibVal_Err_Parse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The certificate request metadata contains the &quot;san&quot; request attribute, and the certification authority is configured with the EDITF_ATTRIBUTESUBJECTALTNAME2 flag. This is a highly dangerous configuration. The request was therefore denied..
        /// </summary>
        internal static string AttribVal_Insecure_Flags {
            get {
                return ResourceManager.GetString("AttribVal_Insecure_Flags", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to adjust begin of certificate validity period to {0} (UTC) as requested by &quot;StartDate&quot; request attribute. The requested date is invalid..
        /// </summary>
        internal static string AttribVal_Invalid_StartDate {
            get {
                return ResourceManager.GetString("AttribVal_Invalid_StartDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} account for {1} is disabled..
        /// </summary>
        internal static string DirVal_Account_Disabled {
            get {
                return ResourceManager.GetString("DirVal_Account_Disabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} account for {1} is member of the forbidden group {2}..
        /// </summary>
        internal static string DirVal_Account_Groups_Disallowed {
            get {
                return ResourceManager.GetString("DirVal_Account_Groups_Disallowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} account for {1} is not member of any allowed group..
        /// </summary>
        internal static string DirVal_Account_Groups_Not_Allowed {
            get {
                return ResourceManager.GetString("DirVal_Account_Groups_Not_Allowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &quot;{0}&quot; does match the expression {1} which disallowed for the object name of {2}..
        /// </summary>
        internal static string DirVal_Disallow_Match {
            get {
                return ResourceManager.GetString("DirVal_Disallow_Match", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} account for {1} is member of the forbidden organizational unit {2}..
        /// </summary>
        internal static string DirVal_Disallow_Match_OU {
            get {
                return ResourceManager.GetString("DirVal_Disallow_Match_OU", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An invalid directory attribute was specified in request policy: {0}..
        /// </summary>
        internal static string DirVal_Invalid_Directory_Attribute {
            get {
                return ResourceManager.GetString("DirVal_Invalid_Directory_Attribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An invalid object category was specified in request policy: {0}..
        /// </summary>
        internal static string DirVal_Invalid_Object_Category {
            get {
                return ResourceManager.GetString("DirVal_Invalid_Object_Category", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More than one {0} account with {1} of {2} was found in the directory..
        /// </summary>
        internal static string DirVal_Invalid_Result_Count {
            get {
                return ResourceManager.GetString("DirVal_Invalid_Result_Count", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The mandatory &quot;{0}&quot; attribute is not present on {1}. Unable to apply syntax rules..
        /// </summary>
        internal static string DirVal_Invalid_Rule_Attribute {
            get {
                return ResourceManager.GetString("DirVal_Invalid_Rule_Attribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No matching identity found for the {0} attribute in certificate request..
        /// </summary>
        internal static string DirVal_No_Cert_Identity {
            get {
                return ResourceManager.GetString("DirVal_No_Cert_Identity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &quot;{0}&quot; does not match any of the allowed patterns for the object name of {1}..
        /// </summary>
        internal static string DirVal_No_Match {
            get {
                return ResourceManager.GetString("DirVal_No_Match", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} account for {1} is not member of any allowed organizational unit..
        /// </summary>
        internal static string DirVal_No_Match_OU {
            get {
                return ResourceManager.GetString("DirVal_No_Match_OU", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No {0} account with {1} of {2} was found in the directory. Search root is {3}..
        /// </summary>
        internal static string DirVal_Nothing_Found {
            get {
                return ResourceManager.GetString("DirVal_Nothing_Found", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Directory query {0} in {1} failed because {2}.
        /// </summary>
        internal static string DirVal_Query_Failed {
            get {
                return ResourceManager.GetString("DirVal_Query_Failed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &quot;{0}&quot; for directory attribute &quot;{1}&quot; that was specified for construction of the mandatory &quot;{2}&quot; subject relative distinguished name for {3} is too long. The maximum length is {4} characters for this RDN but the attribute is {5} characters long..
        /// </summary>
        internal static string DirVal_Rdn_Directory_Attribute_too_long {
            get {
                return ResourceManager.GetString("DirVal_Rdn_Directory_Attribute_too_long", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The directory attribute &quot;{0}&quot; that was specified for construction of the mandatory &quot;{1}&quot; subject relative distinguished name is either not supported or not populated for {2}..
        /// </summary>
        internal static string DirVal_Rdn_Invalid_Directory_Attribute {
            get {
                return ResourceManager.GetString("DirVal_Rdn_Invalid_Directory_Attribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The field name &quot;{0}&quot; that was specified for construction of the mandatory subject relative distinguished name for {1} is unsupported..
        /// </summary>
        internal static string DirVal_Rdn_Invalid_Field {
            get {
                return ResourceManager.GetString("DirVal_Rdn_Invalid_Field", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The attempt to add the mandatory directory attribute &quot;{0}&quot; to the mandatory &quot;{1}&quot; subject alternative name type failed for {2}. This may be because of an incompatibility of data types..
        /// </summary>
        internal static string DirVal_San_Failed_to_add {
            get {
                return ResourceManager.GetString("DirVal_San_Failed_to_add", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The directory attribute &quot;{0}&quot; that was specified for construction of the mandatory &quot;{1}&quot; subject alternative name is either not supported or not populated for {2}..
        /// </summary>
        internal static string DirVal_San_Invalid_Directory_Attribute {
            get {
                return ResourceManager.GetString("DirVal_San_Invalid_Directory_Attribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The field name &quot;{0}&quot; that was specified for construction of the mandatory subject alternative name for {1} is unsupported..
        /// </summary>
        internal static string DirVal_San_Invalid_Field {
            get {
                return ResourceManager.GetString("DirVal_San_Invalid_Field", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} policy module currently does not support standalone certification authorities..
        /// </summary>
        internal static string Events_MODULE_NOT_SUPPORTED {
            get {
                return ResourceManager.GetString("Events_MODULE_NOT_SUPPORTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error initializing Windows Default policy module:
        ///{0}.
        /// </summary>
        internal static string Events_PDEF_FAIL_INIT {
            get {
                return ResourceManager.GetString("Events_PDEF_FAIL_INIT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shutting down Windows Default policy module failed:
        ///{0}.
        /// </summary>
        internal static string Events_PDEF_FAIL_SHUTDOWN {
            get {
                return ResourceManager.GetString("Events_PDEF_FAIL_SHUTDOWN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Windows Default policy module was unable to verify request {0}:
        ///{1}.
        /// </summary>
        internal static string Events_PDEF_FAIL_VERIFY {
            get {
                return ResourceManager.GetString("Events_PDEF_FAIL_VERIFY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request {0} was denied by the Windows Default policy module..
        /// </summary>
        internal static string Events_PDEF_REQUEST_DENIED {
            get {
                return ResourceManager.GetString("Events_PDEF_REQUEST_DENIED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request {0} was denied by the Windows Default policy module: {1}.
        /// </summary>
        internal static string Events_PDEF_REQUEST_DENIED_MESSAGE {
            get {
                return ResourceManager.GetString("Events_PDEF_REQUEST_DENIED_MESSAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} policy module version {1} is ready to process incoming certificate requests..
        /// </summary>
        internal static string Events_PDEF_SUCCESS_INIT {
            get {
                return ResourceManager.GetString("Events_PDEF_SUCCESS_INIT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find policy file for {0}. Request {1} will get issued..
        /// </summary>
        internal static string Events_POLICY_NOT_FOUND {
            get {
                return ResourceManager.GetString("Events_POLICY_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request {0} for {1} was denied because:
        ///{2}.
        /// </summary>
        internal static string Events_REQUEST_DENIED {
            get {
                return ResourceManager.GetString("Events_REQUEST_DENIED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Audit mode is enabled for {1}. Request {0} would get denied because:
        ///{2}.
        /// </summary>
        internal static string Events_REQUEST_DENIED_AUDIT {
            get {
                return ResourceManager.GetString("Events_REQUEST_DENIED_AUDIT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request {0} will get denied. Unable to interpret policy for {1} because:
        ///{2}.
        /// </summary>
        internal static string Events_REQUEST_DENIED_NO_POLICY {
            get {
                return ResourceManager.GetString("Events_REQUEST_DENIED_NO_POLICY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No certificate template information for request {0} could be retrieved from the certification authority service. The request will get denied..
        /// </summary>
        internal static string Events_REQUEST_DENIED_NO_TEMPLATE_INFO {
            get {
                return ResourceManager.GetString("Events_REQUEST_DENIED_NO_TEMPLATE_INFO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No certificate template information for request {0} could be retrieved from the local certificate template cache. The request will get denied..
        /// </summary>
        internal static string Events_REQUEST_DENIED_NO_TEMPLATE_INFO_LOCAL {
            get {
                return ResourceManager.GetString("Events_REQUEST_DENIED_NO_TEMPLATE_INFO_LOCAL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request {0} for {1} will get issued..
        /// </summary>
        internal static string Events_SUCCESS_ISSUED {
            get {
                return ResourceManager.GetString("Events_SUCCESS_ISSUED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request {0} for {1} will be put into pending state..
        /// </summary>
        internal static string Events_SUCCESS_PENDING {
            get {
                return ResourceManager.GetString("Events_SUCCESS_PENDING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The certificate expiration date of request {0} for {1} was reduced to {2} (UTC) due to policy configuration..
        /// </summary>
        internal static string Events_VALIDITY_REDUCED {
            get {
                return ResourceManager.GetString("Events_VALIDITY_REDUCED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The resulting certificate wouldn&apos;t contain any identity in form of a commonName or a Subject Alternative Name..
        /// </summary>
        internal static string FinVal_No_Identity {
            get {
                return ResourceManager.GetString("FinVal_No_Identity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The field name &quot;{0}&quot; that was specified for construction of a Subject Relative Distinguished name is unsupported..
        /// </summary>
        internal static string Rdn_Invalid_Field {
            get {
                return ResourceManager.GetString("Rdn_Invalid_Field", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &quot;{0}&quot; for that was specified for construction of the Subject Relative Distinguished Name of type &quot;{1}&quot; is too long. The maximum length is {2} characters for this RDN, but the attribute is {3} characters long..
        /// </summary>
        internal static string Rdn_Value_Too_Long {
            get {
                return ResourceManager.GetString("Rdn_Value_Too_Long", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cryptographic provider &quot;{0}&quot; used to create the certificate request is explicitly disallowed..
        /// </summary>
        internal static string ReqVal_Crypto_Provider_Disallowed {
            get {
                return ResourceManager.GetString("ReqVal_Crypto_Provider_Disallowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cryptographic provider &quot;{0}&quot; used to create the certificate request is not on the list of allowed providers..
        /// </summary>
        internal static string ReqVal_Crypto_Provider_Not_Allowed {
            get {
                return ResourceManager.GetString("ReqVal_Crypto_Provider_Not_Allowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to determine the cryptographic provider that was used to create the certificate request, but policy requires this information. Probably the certificate request does not contain such information..
        /// </summary>
        internal static string ReqVal_Crypto_Provider_Unknown {
            get {
                return ResourceManager.GetString("ReqVal_Crypto_Provider_Unknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &quot;{0}&quot; does match expression &quot;{1}&quot; which is disallowed for the {2} field..
        /// </summary>
        internal static string ReqVal_Disallow_Match {
            get {
                return ResourceManager.GetString("ReqVal_Disallow_Match", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to parse the configured expiration date specified in certificate request policy..
        /// </summary>
        internal static string ReqVal_Err_NotAfter_Invalid {
            get {
                return ResourceManager.GetString("ReqVal_Err_NotAfter_Invalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate request policy requires issued certificates for this certificate template to expire no later than {0} (UTC), which lies in the past..
        /// </summary>
        internal static string ReqVal_Err_NotAfter_Passed {
            get {
                return ResourceManager.GetString("ReqVal_Err_NotAfter_Passed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to parse the given certificate request. Request type was {0}..
        /// </summary>
        internal static string ReqVal_Err_Parse_Request {
            get {
                return ResourceManager.GetString("ReqVal_Err_Parse_Request", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to parse the Subject Alternative Name certificate request extension..
        /// </summary>
        internal static string ReqVal_Err_Parse_San {
            get {
                return ResourceManager.GetString("ReqVal_Err_Parse_San", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to parse the given subject distinguished name..
        /// </summary>
        internal static string ReqVal_Err_Parse_SubjectDn {
            get {
                return ResourceManager.GetString("ReqVal_Err_Parse_SubjectDn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to match pattern &quot;{0}&quot; with value &quot;{1}&quot; for the {2} field..
        /// </summary>
        internal static string ReqVal_Err_Regex {
            get {
                return ResourceManager.GetString("ReqVal_Err_Regex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} field was found {1} times, but is allowed only {2} times..
        /// </summary>
        internal static string ReqVal_Field_Count_Mismatch {
            get {
                return ResourceManager.GetString("ReqVal_Field_Count_Mismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The mandatory {0} field was not found in the request..
        /// </summary>
        internal static string ReqVal_Field_Missing {
            get {
                return ResourceManager.GetString("ReqVal_Field_Missing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} field is not allowed..
        /// </summary>
        internal static string ReqVal_Field_Not_Allowed {
            get {
                return ResourceManager.GetString("ReqVal_Field_Not_Allowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No allowed patterns are defined for the {0} field..
        /// </summary>
        internal static string ReqVal_Field_Not_Defined {
            get {
                return ResourceManager.GetString("ReqVal_Field_Not_Defined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &quot;{0}&quot; for the {1} field exceeds the maximum allowed length of {2} characters..
        /// </summary>
        internal static string ReqVal_Field_Too_Long {
            get {
                return ResourceManager.GetString("ReqVal_Field_Too_Long", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &quot;{0}&quot; for the {1} field deceeds the minimum required length of {2} characters..
        /// </summary>
        internal static string ReqVal_Field_Too_Short {
            get {
                return ResourceManager.GetString("ReqVal_Field_Too_Short", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The certificate request contains a forbidden X.509 extension with object identifier {0} ({1})..
        /// </summary>
        internal static string ReqVal_Forbidden_Extensions {
            get {
                return ResourceManager.GetString("ReqVal_Forbidden_Extensions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The certificate request does not use a {0} key pair as required by the certificate template, but a {1} key pair..
        /// </summary>
        internal static string ReqVal_Key_Pair_Mismatch {
            get {
                return ResourceManager.GetString("ReqVal_Key_Pair_Mismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key length of {0} Bits is more than the allowed maximum length of {1} Bits..
        /// </summary>
        internal static string ReqVal_Key_Too_Large {
            get {
                return ResourceManager.GetString("ReqVal_Key_Too_Large", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key length of {0} Bits is less than the required minimum length of {1} Bits..
        /// </summary>
        internal static string ReqVal_Key_Too_Small {
            get {
                return ResourceManager.GetString("ReqVal_Key_Too_Small", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &quot;{0}&quot; does not match any of the allowed patterns for the {1} field..
        /// </summary>
        internal static string ReqVal_No_Match {
            get {
                return ResourceManager.GetString("ReqVal_No_Match", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process &quot;{0}&quot; used to create the certificate request is explicitly disallowed..
        /// </summary>
        internal static string ReqVal_Process_Disallowed {
            get {
                return ResourceManager.GetString("ReqVal_Process_Disallowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process &quot;{0}&quot; used to create the certificate request is not on the list of allowed process names..
        /// </summary>
        internal static string ReqVal_Process_Not_Allowed {
            get {
                return ResourceManager.GetString("ReqVal_Process_Not_Allowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to determine the process name that was used to create the certificate request, but policy requires this information. Probably the certificate request does not contain such information..
        /// </summary>
        internal static string ReqVal_Process_Unknown {
            get {
                return ResourceManager.GetString("ReqVal_Process_Unknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The certificate request contains an unsupported Subject Alternative Name type with OID {0}..
        /// </summary>
        internal static string ReqVal_Unsupported_San_Type {
            get {
                return ResourceManager.GetString("ReqVal_Unsupported_San_Type", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to add entry of type &quot;{0}&quot; with value &quot;{1}&quot; to the Subject Alternative Name certificate extension. Either type or value is invalid..
        /// </summary>
        internal static string San_unable_to_add {
            get {
                return ResourceManager.GetString("San_unable_to_add", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &quot;{0}&quot; token for the construction of a Subject Relative Distinguished Name is unknown. Ensure that Directory Service Mapping is enabled if it is an AD attribute, and that the originating certificate request contains the token, if it is a request field..
        /// </summary>
        internal static string Token_invalid {
            get {
                return ResourceManager.GetString("Token_invalid", resourceCulture);
            }
        }
    }
}
