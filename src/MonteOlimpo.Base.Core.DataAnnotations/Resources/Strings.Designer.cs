﻿using System.Reflection;

namespace MonteOlimpo.Base.Core.DataAnnotations.Resources
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Otc.ComponentModel.Annotations.Resources.Strings", typeof(Strings).GetTypeInfo().Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The argument &apos;{0}&apos; cannot be null, empty or contain only white space..
        /// </summary>
        internal static string ArgumentIsNullOrWhitespace
        {
            get
            {
                return ResourceManager.GetString("ArgumentIsNullOrWhitespace", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The associated metadata type for type &apos;{0}&apos; contains the following unknown properties or fields: {1}. Please make sure that the names of these members match the names of the properties on the main type..
        /// </summary>
        internal static string AssociatedMetadataTypeTypeDescriptor_MetadataTypeContainsUnknownProperties
        {
            get
            {
                return ResourceManager.GetString("AssociatedMetadataTypeTypeDescriptor_MetadataTypeContainsUnknownProperties", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; must be public..
        /// </summary>
        internal static string AttributeStore_Type_Must_Be_Public
        {
            get
            {
                return ResourceManager.GetString("AttributeStore_Type_Must_Be_Public", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; does not contain a public method named &apos;{1}&apos;..
        /// </summary>
        internal static string AttributeStore_Unknown_Method
        {
            get
            {
                return ResourceManager.GetString("AttributeStore_Unknown_Method", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; does not contain a public property named &apos;{1}&apos;..
        /// </summary>
        internal static string AttributeStore_Unknown_Property
        {
            get
            {
                return ResourceManager.GetString("AttributeStore_Unknown_Property", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Value cannot be null or empty..
        /// </summary>
        internal static string Common_NullOrEmpty
        {
            get
            {
                return ResourceManager.GetString("Common_NullOrEmpty", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The property {0}.{1} could not be found..
        /// </summary>
        internal static string Common_PropertyNotFound
        {
            get
            {
                return ResourceManager.GetString("Common_PropertyNotFound", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; and &apos;{1}&apos; do not match..
        /// </summary>
        internal static string CompareAttribute_MustMatch
        {
            get
            {
                return ResourceManager.GetString("CompareAttribute_MustMatch", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Could not find a property named {0}..
        /// </summary>
        internal static string CompareAttribute_UnknownProperty
        {
            get
            {
                return ResourceManager.GetString("CompareAttribute_UnknownProperty", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The {0} field is not a valid credit card number..
        /// </summary>
        internal static string CreditCardAttribute_Invalid
        {
            get
            {
                return ResourceManager.GetString("CreditCardAttribute_Invalid", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The CustomValidationAttribute method &apos;{0}&apos; in type &apos;{1}&apos; must return System.ComponentModel.DataAnnotations.ValidationResult.  Use System.ComponentModel.DataAnnotations.ValidationResult.Success to represent success..
        /// </summary>
        internal static string CustomValidationAttribute_Method_Must_Return_ValidationResult
        {
            get
            {
                return ResourceManager.GetString("CustomValidationAttribute_Method_Must_Return_ValidationResult", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The CustomValidationAttribute method &apos;{0}&apos; does not exist in type &apos;{1}&apos; or is not public and static..
        /// </summary>
        internal static string CustomValidationAttribute_Method_Not_Found
        {
            get
            {
                return ResourceManager.GetString("CustomValidationAttribute_Method_Not_Found", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The CustomValidationAttribute.Method was not specified..
        /// </summary>
        internal static string CustomValidationAttribute_Method_Required
        {
            get
            {
                return ResourceManager.GetString("CustomValidationAttribute_Method_Required", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The CustomValidationAttribute method &apos;{0}&apos; in type &apos;{1}&apos; must match the expected signature: public static ValidationResult {0}(object value, ValidationContext context).  The value can be strongly typed.  The ValidationContext parameter is optional..
        /// </summary>
        internal static string CustomValidationAttribute_Method_Signature
        {
            get
            {
                return ResourceManager.GetString("CustomValidationAttribute_Method_Signature", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Could not convert the value of type &apos;{0}&apos; to &apos;{1}&apos; as expected by method {2}.{3}..
        /// </summary>
        internal static string CustomValidationAttribute_Type_Conversion_Failed
        {
            get
            {
                return ResourceManager.GetString("CustomValidationAttribute_Type_Conversion_Failed", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The custom validation type &apos;{0}&apos; must be public..
        /// </summary>
        internal static string CustomValidationAttribute_Type_Must_Be_Public
        {
            get
            {
                return ResourceManager.GetString("CustomValidationAttribute_Type_Must_Be_Public", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {0} is not valid..
        /// </summary>
        internal static string CustomValidationAttribute_ValidationError
        {
            get
            {
                return ResourceManager.GetString("CustomValidationAttribute_ValidationError", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The CustomValidationAttribute.ValidatorType was not specified..
        /// </summary>
        internal static string CustomValidationAttribute_ValidatorType_Required
        {
            get
            {
                return ResourceManager.GetString("CustomValidationAttribute_ValidatorType_Required", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The custom DataType string cannot be null or empty..
        /// </summary>
        internal static string DataTypeAttribute_EmptyDataTypeString
        {
            get
            {
                return ResourceManager.GetString("DataTypeAttribute_EmptyDataTypeString", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The {0} property has not been set.  Use the {1} method to get the value..
        /// </summary>
        internal static string DisplayAttribute_PropertyNotSet
        {
            get
            {
                return ResourceManager.GetString("DisplayAttribute_PropertyNotSet", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The {0} field is not a valid e-mail address..
        /// </summary>
        internal static string EmailAddressAttribute_Invalid
        {
            get
            {
                return ResourceManager.GetString("EmailAddressAttribute_Invalid", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The type provided for EnumDataTypeAttribute cannot be null..
        /// </summary>
        internal static string EnumDataTypeAttribute_TypeCannotBeNull
        {
            get
            {
                return ResourceManager.GetString("EnumDataTypeAttribute_TypeCannotBeNull", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; needs to represent an enumeration type..
        /// </summary>
        internal static string EnumDataTypeAttribute_TypeNeedsToBeAnEnum
        {
            get
            {
                return ResourceManager.GetString("EnumDataTypeAttribute_TypeNeedsToBeAnEnum", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The {0} field only accepts files with the following extensions: {1}.
        /// </summary>
        internal static string FileExtensionsAttribute_Invalid
        {
            get
            {
                return ResourceManager.GetString("FileExtensionsAttribute_Invalid", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Cannot retrieve property &apos;{0}&apos; because localization failed.  Type &apos;{1}&apos; is not public or does not contain a public static string property with the name &apos;{2}&apos;..
        /// </summary>
        internal static string LocalizableString_LocalizationFailed
        {
            get
            {
                return ResourceManager.GetString("LocalizableString_LocalizationFailed", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to MaxLengthAttribute must have a Length value that is greater than zero. Use MaxLength() without parameters to indicate that the string or array can have the maximum allowable length..
        /// </summary>
        internal static string MaxLengthAttribute_InvalidMaxLength
        {
            get
            {
                return ResourceManager.GetString("MaxLengthAttribute_InvalidMaxLength", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The field {0} must be a string or array type with a maximum length of &apos;{1}&apos;..
        /// </summary>
        internal static string MaxLengthAttribute_ValidationError
        {
            get
            {
                return ResourceManager.GetString("MaxLengthAttribute_ValidationError", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to MetadataClassType cannot be null..
        /// </summary>
        internal static string MetadataTypeAttribute_TypeCannotBeNull
        {
            get
            {
                return ResourceManager.GetString("MetadataTypeAttribute_TypeCannotBeNull", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to MinLengthAttribute must have a Length value that is zero or greater..
        /// </summary>
        internal static string MinLengthAttribute_InvalidMinLength
        {
            get
            {
                return ResourceManager.GetString("MinLengthAttribute_InvalidMinLength", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The field {0} must be a string or array type with a minimum length of &apos;{1}&apos;..
        /// </summary>
        internal static string MinLengthAttribute_ValidationError
        {
            get
            {
                return ResourceManager.GetString("MinLengthAttribute_ValidationError", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The {0} field is not a valid phone number..
        /// </summary>
        internal static string PhoneAttribute_Invalid
        {
            get
            {
                return ResourceManager.GetString("PhoneAttribute_Invalid", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The type {0} must implement {1}..
        /// </summary>
        internal static string RangeAttribute_ArbitraryTypeNotIComparable
        {
            get
            {
                return ResourceManager.GetString("RangeAttribute_ArbitraryTypeNotIComparable", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The maximum value &apos;{0}&apos; must be greater than or equal to the minimum value &apos;{1}&apos;..
        /// </summary>
        internal static string RangeAttribute_MinGreaterThanMax
        {
            get
            {
                return ResourceManager.GetString("RangeAttribute_MinGreaterThanMax", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The minimum and maximum values must be set..
        /// </summary>
        internal static string RangeAttribute_Must_Set_Min_And_Max
        {
            get
            {
                return ResourceManager.GetString("RangeAttribute_Must_Set_Min_And_Max", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The OperandType must be set when strings are used for minimum and maximum values..
        /// </summary>
        internal static string RangeAttribute_Must_Set_Operand_Type
        {
            get
            {
                return ResourceManager.GetString("RangeAttribute_Must_Set_Operand_Type", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The field {0} must be between {1} and {2}..
        /// </summary>
        internal static string RangeAttribute_ValidationError
        {
            get
            {
                return ResourceManager.GetString("RangeAttribute_ValidationError", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The field {0} must match the regular expression &apos;{1}&apos;..
        /// </summary>
        internal static string RegexAttribute_ValidationError
        {
            get
            {
                return ResourceManager.GetString("RegexAttribute_ValidationError", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The pattern must be set to a valid regular expression..
        /// </summary>
        internal static string RegularExpressionAttribute_Empty_Pattern
        {
            get
            {
                return ResourceManager.GetString("RegularExpressionAttribute_Empty_Pattern", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The {0} field is required..
        /// </summary>
        internal static string RequiredAttribute_ValidationError
        {
            get
            {
                return ResourceManager.GetString("RequiredAttribute_ValidationError", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The maximum length must be a nonnegative integer..
        /// </summary>
        internal static string StringLengthAttribute_InvalidMaxLength
        {
            get
            {
                return ResourceManager.GetString("StringLengthAttribute_InvalidMaxLength", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The field {0} must be a string with a maximum length of {1}..
        /// </summary>
        internal static string StringLengthAttribute_ValidationError
        {
            get
            {
                return ResourceManager.GetString("StringLengthAttribute_ValidationError", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The field {0} must be a string with a minimum length of {2} and a maximum length of {1}..
        /// </summary>
        internal static string StringLengthAttribute_ValidationErrorIncludingMinimum
        {
            get
            {
                return ResourceManager.GetString("StringLengthAttribute_ValidationErrorIncludingMinimum", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The key parameter at position {0} with value &apos;{1}&apos; is not a string. Every key control parameter must be a string..
        /// </summary>
        internal static string UIHintImplementation_ControlParameterKeyIsNotAString
        {
            get
            {
                return ResourceManager.GetString("UIHintImplementation_ControlParameterKeyIsNotAString", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The key parameter at position {0} is null. Every key control parameter must be a string..
        /// </summary>
        internal static string UIHintImplementation_ControlParameterKeyIsNull
        {
            get
            {
                return ResourceManager.GetString("UIHintImplementation_ControlParameterKeyIsNull", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The key parameter at position {0} with value &apos;{1}&apos; occurs more than once..
        /// </summary>
        internal static string UIHintImplementation_ControlParameterKeyOccursMoreThanOnce
        {
            get
            {
                return ResourceManager.GetString("UIHintImplementation_ControlParameterKeyOccursMoreThanOnce", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The number of control parameters must be even..
        /// </summary>
        internal static string UIHintImplementation_NeedEvenNumberOfControlParameters
        {
            get
            {
                return ResourceManager.GetString("UIHintImplementation_NeedEvenNumberOfControlParameters", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The {0} field is not a valid fully-qualified http, https, or ftp URL..
        /// </summary>
        internal static string UrlAttribute_Invalid
        {
            get
            {
                return ResourceManager.GetString("UrlAttribute_Invalid", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Either ErrorMessageString or ErrorMessageResourceName must be set, but not both..
        /// </summary>
        internal static string ValidationAttribute_Cannot_Set_ErrorMessage_And_Resource
        {
            get
            {
                return ResourceManager.GetString("ValidationAttribute_Cannot_Set_ErrorMessage_And_Resource", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to IsValid(object value) has not been implemented by this class.  The preferred entry point is GetValidationResult() and classes should override IsValid(object value, ValidationContext context)..
        /// </summary>
        internal static string ValidationAttribute_IsValid_NotImplemented
        {
            get
            {
                return ResourceManager.GetString("ValidationAttribute_IsValid_NotImplemented", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Both ErrorMessageResourceType and ErrorMessageResourceName need to be set on this attribute..
        /// </summary>
        internal static string ValidationAttribute_NeedBothResourceTypeAndResourceName
        {
            get
            {
                return ResourceManager.GetString("ValidationAttribute_NeedBothResourceTypeAndResourceName", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The property &apos;{0}&apos; on resource type &apos;{1}&apos; is not a string type..
        /// </summary>
        internal static string ValidationAttribute_ResourcePropertyNotStringType
        {
            get
            {
                return ResourceManager.GetString("ValidationAttribute_ResourcePropertyNotStringType", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The resource type &apos;{0}&apos; does not have an accessible static property named &apos;{1}&apos;..
        /// </summary>
        internal static string ValidationAttribute_ResourceTypeDoesNotHaveProperty
        {
            get
            {
                return ResourceManager.GetString("ValidationAttribute_ResourceTypeDoesNotHaveProperty", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The field {0} is invalid..
        /// </summary>
        internal static string ValidationAttribute_ValidationError
        {
            get
            {
                return ResourceManager.GetString("ValidationAttribute_ValidationError", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The ValidationContext for the type &apos;{0}&apos;, member name &apos;{1}&apos; must provide the MethodInfo..
        /// </summary>
        internal static string ValidationContext_Must_Be_Method
        {
            get
            {
                return ResourceManager.GetString("ValidationContext_Must_Be_Method", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to A service of type &apos;{0}&apos; already exists in the container..
        /// </summary>
        internal static string ValidationContextServiceContainer_ItemAlreadyExists
        {
            get
            {
                return ResourceManager.GetString("ValidationContextServiceContainer_ItemAlreadyExists", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The instance provided must match the ObjectInstance on the ValidationContext supplied..
        /// </summary>
        internal static string Validator_InstanceMustMatchValidationContextInstance
        {
            get
            {
                return ResourceManager.GetString("Validator_InstanceMustMatchValidationContextInstance", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The value for property &apos;{0}&apos; must be of type &apos;{1}&apos;..
        /// </summary>
        internal static string Validator_Property_Value_Wrong_Type
        {
            get
            {
                return ResourceManager.GetString("Validator_Property_Value_Wrong_Type", resourceCulture);
            }
        }
    }
}