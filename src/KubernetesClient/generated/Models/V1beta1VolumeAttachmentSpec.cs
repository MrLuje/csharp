// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// VolumeAttachmentSpec is the specification of a VolumeAttachment
    /// request.
    /// </summary>
    public partial class V1beta1VolumeAttachmentSpec
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1VolumeAttachmentSpec
        /// class.
        /// </summary>
        public V1beta1VolumeAttachmentSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1VolumeAttachmentSpec
        /// class.
        /// </summary>
        /// <param name="attacher">Attacher indicates the name of the volume
        /// driver that MUST handle this request. This is the name returned by
        /// GetPluginName().</param>
        /// <param name="nodeName">The node that the volume should be attached
        /// to.</param>
        /// <param name="source">Source represents the volume that should be
        /// attached.</param>
        public V1beta1VolumeAttachmentSpec(string attacher, string nodeName, V1beta1VolumeAttachmentSource source)
        {
            Attacher = attacher;
            NodeName = nodeName;
            Source = source;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets attacher indicates the name of the volume driver that
        /// MUST handle this request. This is the name returned by
        /// GetPluginName().
        /// </summary>
        [JsonProperty(PropertyName = "attacher")]
        public string Attacher { get; set; }

        /// <summary>
        /// Gets or sets the node that the volume should be attached to.
        /// </summary>
        [JsonProperty(PropertyName = "nodeName")]
        public string NodeName { get; set; }

        /// <summary>
        /// Gets or sets source represents the volume that should be attached.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public V1beta1VolumeAttachmentSource Source { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Attacher == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Attacher");
            }
            if (NodeName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NodeName");
            }
            if (Source == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Source");
            }
            if (Source != null)
            {
                Source.Validate();
            }
        }
    }
}
