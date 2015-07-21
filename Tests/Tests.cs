namespace Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NotDefault;

    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Byte()
        {
            byte @byte = 123;
            byte? nbyte = 123;

            // byte
            Assert.IsTrue(@byte.NotDefault());
            Assert.IsFalse(default(byte).NotDefault());

            // byte?
            Assert.IsTrue(nbyte.NotDefault());
            Assert.IsFalse(default(byte?).NotDefault());

            sbyte @sbyte = 123;
            sbyte? nsbyte = 123;

            // sbyte
            Assert.IsTrue(@sbyte.NotDefault());
            Assert.IsFalse(default(sbyte).NotDefault());

            // sbyte?
            Assert.IsTrue(nsbyte.NotDefault());
            Assert.IsFalse(default(sbyte?).NotDefault());
        }

        [TestMethod]
        public void Short()
        {
            short @short = 123;
            short? nshort = 123;

            // short
            Assert.IsTrue(@short.NotDefault());
            Assert.IsFalse(default(short).NotDefault());

            // short?
            Assert.IsTrue(nshort.NotDefault());
            Assert.IsFalse(default(short?).NotDefault());

            ushort @ushort = 123;
            ushort? nushort = 123;

            // ushort
            Assert.IsTrue(@ushort.NotDefault());
            Assert.IsFalse(default(ushort).NotDefault());

            // ushort?
            Assert.IsTrue(nushort.NotDefault());
            Assert.IsFalse(default(ushort?).NotDefault());
        }

        [TestMethod]
        public void Int()
        {
            int @int = 123;
            int? nint = 123;

            // int
            Assert.IsTrue(@int.NotDefault());
            Assert.IsFalse(default(int).NotDefault());

            // int?
            Assert.IsTrue(nint.NotDefault());
            Assert.IsFalse(default(int?).NotDefault());

            uint @uint = 123u;
            uint? nuint = 123u;

            // uint
            Assert.IsTrue(@uint.NotDefault());
            Assert.IsFalse(default(uint).NotDefault());

            // uint?
            Assert.IsTrue(nuint.NotDefault());
            Assert.IsFalse(default(uint?).NotDefault());
        }

        [TestMethod]
        public void Long()
        {
            long @long = 123L;
            long? nlong = 123L;

            // long
            Assert.IsTrue(@long.NotDefault());
            Assert.IsFalse(default(long).NotDefault());

            // long?
            Assert.IsTrue(nlong.NotDefault());
            Assert.IsFalse(default(long?).NotDefault());

            ulong @ulong = 123ul;
            ulong? nulong = 123ul;

            // ulong
            Assert.IsTrue(@ulong.NotDefault());
            Assert.IsFalse(default(ulong).NotDefault());

            // ulong?
            Assert.IsTrue(nulong.NotDefault());
            Assert.IsFalse(default(ulong?).NotDefault());
        }

        [TestMethod]
        public void Float()
        {
            float @float = 12.3f;
            float? nfloat = 12.3f; 

            // float
            Assert.IsTrue(@float.NotDefault());
            Assert.IsFalse(default(float).NotDefault());

            // float?
            Assert.IsTrue(nfloat.NotDefault());
            Assert.IsFalse(default(float?).NotDefault());
        }

        [TestMethod]
        public void Double()
        {
            double @double = 12.3d;
            double? ndouble = 12.3d;

            // double
            Assert.IsTrue(@double.NotDefault());
            Assert.IsFalse(default(double).NotDefault());

            // double
            Assert.IsTrue(ndouble.NotDefault());
            Assert.IsFalse(default(double?).NotDefault());
        }

        [TestMethod]
        public void Decimal()
        {
            decimal @decimal = 12.3m;
            decimal? ndecimal = 12.3m;

            // decimal
            Assert.IsTrue(@decimal.NotDefault());
            Assert.IsFalse(default(decimal).NotDefault());

            // decimal?
            Assert.IsTrue(ndecimal.NotDefault());
            Assert.IsFalse(default(decimal?).NotDefault());
        }

        [TestMethod]
        public void Char()
        {
            char @char = 's';
            char? nchar = 's';

            // char
            Assert.IsTrue(@char.NotDefault());
            Assert.IsFalse(default(char).NotDefault());

            // char?
            Assert.IsTrue(nchar.NotDefault());
            Assert.IsFalse(default(char?).NotDefault());
        }

        [TestMethod]
        public void String()
        {
            string @string = "string";

            Assert.IsTrue(@string.NotDefault());
            Assert.IsFalse(default(string).NotDefault());
        }

        [TestMethod]
        public void Bool()
        {
            bool @bool = true;
            bool? nbool = true;

            Assert.IsTrue(@bool.NotDefault());
            Assert.IsFalse(default(bool).NotDefault());

            Assert.IsTrue(nbool.NotDefault());
            Assert.IsFalse(default(bool?).NotDefault());
        }

        [TestMethod]
        public void Object()
        {
            object @object = new { Foo = "Bar" };

            Assert.IsTrue(@object.NotDefault());
            Assert.IsFalse(default(object).NotDefault());
        }
    }
}
