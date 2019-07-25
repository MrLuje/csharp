// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// CustomResourceDefinitionSpec describes how a user wants their resource
    /// to appear
    /// </summary>
    public partial class V1beta1CustomResourceDefinitionSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// V1beta1CustomResourceDefinitionSpec class.
        /// </summary>
        public V1beta1CustomResourceDefinitionSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// V1beta1CustomResourceDefinitionSpec class.
        /// </summary>
        /// <param name="group">Group is the group this resource belongs
        /// in</param>
        /// <param name="names">Names are the names used to describe this
        /// custom resource</param>
        /// <param name="scope">Scope indicates whether this resource is
        /// cluster or namespace scoped.  Default is namespaced</param>
        /// <param name="additionalPrinterColumns">AdditionalPrinterColumns are
        /// additional columns shown e.g. in kubectl next to the name. Defaults
        /// to a created-at column. Optional, the global columns for all
        /// versions. Top-level and per-version columns are mutually
        /// exclusive.</param>
        /// <param name="conversion">`conversion` defines conversion settings
        /// for the CRD.</param>
        /// <param name="preserveUnknownFields">preserveUnknownFields disables
        /// pruning of object fields which are not specified in the OpenAPI
        /// schema. apiVersion, kind, metadata and known fields inside metadata
        /// are always preserved. Defaults to true in v1beta and will default
        /// to false in v1.</param>
        /// <param name="subresources">Subresources describes the subresources
        /// for CustomResource Optional, the global subresources for all
        /// versions. Top-level and per-version subresources are mutually
        /// exclusive.</param>
        /// <param name="validation">Validation describes the validation
        /// methods for CustomResources Optional, the global validation schema
        /// for all versions. Top-level and per-version schemas are mutually
        /// exclusive.</param>
        /// <param name="version">Version is the version this resource belongs
        /// in Should be always first item in Versions field if provided.
        /// Optional, but at least one of Version or Versions must be set.
        /// Deprecated: Please use `Versions`.</param>
        /// <param name="versions">Versions is the list of all supported
        /// versions for this resource. If Version field is provided, this
        /// field is optional. Validation: All versions must use the same
        /// validation schema for now. i.e., top level Validation field is
        /// applied to all of these versions. Order: The version name will be
        /// used to compute the order. If the version string is "kube-like", it
        /// will sort above non "kube-like" version strings, which are ordered
        /// lexicographically. "Kube-like" versions start with a "v", then are
        /// followed by a number (the major version), then optionally the
        /// string "alpha" or "beta" and another number (the minor version).
        /// These are sorted first by GA &gt; beta &gt; alpha (where GA is a
        /// version with no suffix such as beta or alpha), and then by
        /// comparing major version, then minor version. An example sorted list
        /// of versions: v10, v2, v1, v11beta2, v10beta3, v3beta1, v12alpha1,
        /// v11alpha2, foo1, foo10.</param>
        public V1beta1CustomResourceDefinitionSpec(string group, V1beta1CustomResourceDefinitionNames names, string scope, IList<V1beta1CustomResourceColumnDefinition> additionalPrinterColumns = default(IList<V1beta1CustomResourceColumnDefinition>), V1beta1CustomResourceConversion conversion = default(V1beta1CustomResourceConversion), bool? preserveUnknownFields = default(bool?), V1beta1CustomResourceSubresources subresources = default(V1beta1CustomResourceSubresources), V1beta1CustomResourceValidation validation = default(V1beta1CustomResourceValidation), string version = default(string), IList<V1beta1CustomResourceDefinitionVersion> versions = default(IList<V1beta1CustomResourceDefinitionVersion>))
        {
            AdditionalPrinterColumns = additionalPrinterColumns;
            Conversion = conversion;
            Group = group;
            Names = names;
            PreserveUnknownFields = preserveUnknownFields;
            Scope = scope;
            Subresources = subresources;
            Validation = validation;
            Version = version;
            Versions = versions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets additionalPrinterColumns are additional columns shown
        /// e.g. in kubectl next to the name. Defaults to a created-at column.
        /// Optional, the global columns for all versions. Top-level and
        /// per-version columns are mutually exclusive.
        /// </summary>
        [JsonProperty(PropertyName = "additionalPrinterColumns")]
        public IList<V1beta1CustomResourceColumnDefinition> AdditionalPrinterColumns { get; set; }

        /// <summary>
        /// Gets or sets `conversion` defines conversion settings for the CRD.
        /// </summary>
        [JsonProperty(PropertyName = "conversion")]
        public V1beta1CustomResourceConversion Conversion { get; set; }

        /// <summary>
        /// Gets or sets group is the group this resource belongs in
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        /// <summary>
        /// Gets or sets names are the names used to describe this custom
        /// resource
        /// </summary>
        [JsonProperty(PropertyName = "names")]
        public V1beta1CustomResourceDefinitionNames Names { get; set; }

        /// <summary>
        /// Gets or sets preserveUnknownFields disables pruning of object
        /// fields which are not specified in the OpenAPI schema. apiVersion,
        /// kind, metadata and known fields inside metadata are always
        /// preserved. Defaults to true in v1beta and will default to false in
        /// v1.
        /// </summary>
        [JsonProperty(PropertyName = "preserveUnknownFields")]
        public bool? PreserveUnknownFields { get; set; }

        /// <summary>
        /// Gets or sets scope indicates whether this resource is cluster or
        /// namespace scoped.  Default is namespaced
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or sets subresources describes the subresources for
        /// CustomResource Optional, the global subresources for all versions.
        /// Top-level and per-version subresources are mutually exclusive.
        /// </summary>
        [JsonProperty(PropertyName = "subresources")]
        public V1beta1CustomResourceSubresources Subresources { get; set; }

        /// <summary>
        /// Gets or sets validation describes the validation methods for
        /// CustomResources Optional, the global validation schema for all
        /// versions. Top-level and per-version schemas are mutually exclusive.
        /// </summary>
        [JsonProperty(PropertyName = "validation")]
        public V1beta1CustomResourceValidation Validation { get; set; }

        /// <summary>
        /// Gets or sets version is the version this resource belongs in Should
        /// be always first item in Versions field if provided. Optional, but
        /// at least one of Version or Versions must be set. Deprecated: Please
        /// use `Versions`.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets versions is the list of all supported versions for
        /// this resource. If Version field is provided, this field is
        /// optional. Validation: All versions must use the same validation
        /// schema for now. i.e., top level Validation field is applied to all
        /// of these versions. Order: The version name will be used to compute
        /// the order. If the version string is "kube-like", it will sort above
        /// non "kube-like" version strings, which are ordered
        /// lexicographically. "Kube-like" versions start with a "v", then are
        /// followed by a number (the major version), then optionally the
        /// string "alpha" or "beta" and another number (the minor version).
        /// These are sorted first by GA &amp;gt; beta &amp;gt; alpha (where GA
        /// is a version with no suffix such as beta or alpha), and then by
        /// comparing major version, then minor version. An example sorted list
        /// of versions: v10, v2, v1, v11beta2, v10beta3, v3beta1, v12alpha1,
        /// v11alpha2, foo1, foo10.
        /// </summary>
        [JsonProperty(PropertyName = "versions")]
        public IList<V1beta1CustomResourceDefinitionVersion> Versions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Group == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Group");
            }
            if (Names == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Names");
            }
            if (Scope == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Scope");
            }
            if (AdditionalPrinterColumns != null)
            {
                foreach (var element in AdditionalPrinterColumns)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Conversion != null)
            {
                Conversion.Validate();
            }
            if (Names != null)
            {
                Names.Validate();
            }
            if (Subresources != null)
            {
                Subresources.Validate();
            }
            if (Versions != null)
            {
                foreach (var element1 in Versions)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
