// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Paper
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The invitee info with permission level object</para>
    /// </summary>
    public class InviteeInfoWithPermissionLevel
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<InviteeInfoWithPermissionLevel> Encoder = new InviteeInfoWithPermissionLevelEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<InviteeInfoWithPermissionLevel> Decoder = new InviteeInfoWithPermissionLevelDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="InviteeInfoWithPermissionLevel"
        /// /> class.</para>
        /// </summary>
        /// <param name="invitee">Email invited to the Paper doc.</param>
        /// <param name="permissionLevel">Permission level for the invitee.</param>
        public InviteeInfoWithPermissionLevel(Dropbox.Api.Sharing.InviteeInfo invitee,
                                              PaperDocPermissionLevel permissionLevel)
        {
            if (invitee == null)
            {
                throw new sys.ArgumentNullException("invitee");
            }

            if (permissionLevel == null)
            {
                throw new sys.ArgumentNullException("permissionLevel");
            }

            this.Invitee = invitee;
            this.PermissionLevel = permissionLevel;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="InviteeInfoWithPermissionLevel"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public InviteeInfoWithPermissionLevel()
        {
        }

        /// <summary>
        /// <para>Email invited to the Paper doc.</para>
        /// </summary>
        public Dropbox.Api.Sharing.InviteeInfo Invitee { get; protected set; }

        /// <summary>
        /// <para>Permission level for the invitee.</para>
        /// </summary>
        public PaperDocPermissionLevel PermissionLevel { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="InviteeInfoWithPermissionLevel" />.</para>
        /// </summary>
        private class InviteeInfoWithPermissionLevelEncoder : enc.StructEncoder<InviteeInfoWithPermissionLevel>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(InviteeInfoWithPermissionLevel value, enc.IJsonWriter writer)
            {
                WriteProperty("invitee", value.Invitee, writer, Dropbox.Api.Sharing.InviteeInfo.Encoder);
                WriteProperty("permission_level", value.PermissionLevel, writer, Dropbox.Api.Paper.PaperDocPermissionLevel.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="InviteeInfoWithPermissionLevel" />.</para>
        /// </summary>
        private class InviteeInfoWithPermissionLevelDecoder : enc.StructDecoder<InviteeInfoWithPermissionLevel>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="InviteeInfoWithPermissionLevel"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override InviteeInfoWithPermissionLevel Create()
            {
                return new InviteeInfoWithPermissionLevel();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(InviteeInfoWithPermissionLevel value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "invitee":
                        value.Invitee = Dropbox.Api.Sharing.InviteeInfo.Decoder.Decode(reader);
                        break;
                    case "permission_level":
                        value.PermissionLevel = Dropbox.Api.Paper.PaperDocPermissionLevel.Decoder.Decode(reader);
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