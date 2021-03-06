// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The account state object</para>
    /// </summary>
    public class AccountState
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<AccountState> Encoder = new AccountStateEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<AccountState> Decoder = new AccountStateDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AccountState" /> class.</para>
        /// </summary>
        public AccountState()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Locked</para>
        /// </summary>
        public bool IsLocked
        {
            get
            {
                return this is Locked;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Locked, or <c>null</c>.</para>
        /// </summary>
        public Locked AsLocked
        {
            get
            {
                return this as Locked;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Unlocked</para>
        /// </summary>
        public bool IsUnlocked
        {
            get
            {
                return this is Unlocked;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Unlocked, or <c>null</c>.</para>
        /// </summary>
        public Unlocked AsUnlocked
        {
            get
            {
                return this as Unlocked;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="AccountState" />.</para>
        /// </summary>
        private class AccountStateEncoder : enc.StructEncoder<AccountState>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(AccountState value, enc.IJsonWriter writer)
            {
                if (value is Locked)
                {
                    WriteProperty(".tag", "locked", writer, enc.StringEncoder.Instance);
                    Locked.Encoder.EncodeFields((Locked)value, writer);
                    return;
                }
                if (value is Unlocked)
                {
                    WriteProperty(".tag", "unlocked", writer, enc.StringEncoder.Instance);
                    Unlocked.Encoder.EncodeFields((Unlocked)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="AccountState" />.</para>
        /// </summary>
        private class AccountStateDecoder : enc.UnionDecoder<AccountState>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="AccountState" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override AccountState Create()
            {
                return new AccountState();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override AccountState Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "locked":
                        return Locked.Decoder.DecodeFields(reader);
                    case "unlocked":
                        return Unlocked.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The locked object</para>
        /// </summary>
        public sealed class Locked : AccountState
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Locked> Encoder = new LockedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Locked> Decoder = new LockedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Locked" /> class.</para>
            /// </summary>
            private Locked()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Locked</para>
            /// </summary>
            public static readonly Locked Instance = new Locked();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Locked" />.</para>
            /// </summary>
            private class LockedEncoder : enc.StructEncoder<Locked>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Locked value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Locked" />.</para>
            /// </summary>
            private class LockedDecoder : enc.StructDecoder<Locked>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Locked" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Locked Create()
                {
                    return Locked.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The unlocked object</para>
        /// </summary>
        public sealed class Unlocked : AccountState
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Unlocked> Encoder = new UnlockedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Unlocked> Decoder = new UnlockedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Unlocked" /> class.</para>
            /// </summary>
            private Unlocked()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Unlocked</para>
            /// </summary>
            public static readonly Unlocked Instance = new Unlocked();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Unlocked" />.</para>
            /// </summary>
            private class UnlockedEncoder : enc.StructEncoder<Unlocked>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Unlocked value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Unlocked" />.</para>
            /// </summary>
            private class UnlockedDecoder : enc.StructDecoder<Unlocked>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Unlocked" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Unlocked Create()
                {
                    return Unlocked.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : AccountState
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
