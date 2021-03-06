// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.CloudDocs
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The get metadata error object</para>
    /// </summary>
    public class GetMetadataError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GetMetadataError> Encoder = new GetMetadataErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GetMetadataError> Decoder = new GetMetadataErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetMetadataError" />
        /// class.</para>
        /// </summary>
        /// <param name="getMetadataErrorTag">The get metadata error tag</param>
        public GetMetadataError(GetMetadataErrorTagUnion getMetadataErrorTag = null)
        {
            this.GetMetadataErrorTag = getMetadataErrorTag;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetMetadataError" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public GetMetadataError()
        {
        }

        /// <summary>
        /// <para>Gets the get metadata error tag of the get metadata error</para>
        /// </summary>
        public GetMetadataErrorTagUnion GetMetadataErrorTag { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GetMetadataError" />.</para>
        /// </summary>
        private class GetMetadataErrorEncoder : enc.StructEncoder<GetMetadataError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GetMetadataError value, enc.IJsonWriter writer)
            {
                if (value.GetMetadataErrorTag != null)
                {
                    WriteProperty("get_metadata_error_tag", value.GetMetadataErrorTag, writer, global::Dropbox.Api.CloudDocs.GetMetadataErrorTagUnion.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GetMetadataError" />.</para>
        /// </summary>
        private class GetMetadataErrorDecoder : enc.StructDecoder<GetMetadataError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GetMetadataError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GetMetadataError Create()
            {
                return new GetMetadataError();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GetMetadataError value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "get_metadata_error_tag":
                        value.GetMetadataErrorTag = global::Dropbox.Api.CloudDocs.GetMetadataErrorTagUnion.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
