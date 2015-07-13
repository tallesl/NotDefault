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
            var @byte = (byte)123;
            var @sbyte = (sbyte)123;

            // byte
            Assert.IsTrue(@byte.NotDefault());
            Assert.IsFalse(default(byte).NotDefault());

            // sbyte
            Assert.IsTrue(@sbyte.NotDefault());
            Assert.IsFalse(default(sbyte).NotDefault());

            // byte?
            Assert.IsTrue((@byte as byte?).NotDefault());
            Assert.IsFalse(default(byte?).NotDefault());

            // sbyte?
            Assert.IsTrue((@sbyte as sbyte?).NotDefault());
            Assert.IsFalse(default(sbyte?).NotDefault());
        }

        [TestMethod]
        public void Short()
        {
            var @short = (short)123;
            var @ushort = (ushort)123;

            // short
            Assert.IsTrue(@short.NotDefault());
            Assert.IsFalse(default(short).NotDefault());

            // ushort
            Assert.IsTrue(@ushort.NotDefault());
            Assert.IsFalse(default(ushort).NotDefault());

            // short?
            Assert.IsTrue((@short as short?).NotDefault());
            Assert.IsFalse(default(short?).NotDefault());

            // ushort?
            Assert.IsTrue((@ushort as ushort?).NotDefault());
            Assert.IsFalse(default(ushort?).NotDefault());
        }

        [TestMethod]
        public void Int()
        {
            var @int = 123;
            var @uint = (uint)123;

            // int
            Assert.IsTrue(@int.NotDefault());
            Assert.IsFalse(default(int).NotDefault());

            // uint
            Assert.IsTrue(@uint.NotDefault());
            Assert.IsFalse(default(uint).NotDefault());

            // int?
            Assert.IsTrue((@int as int?).NotDefault());
            Assert.IsFalse(default(int?).NotDefault());

            // uint?
            Assert.IsTrue((@uint as uint?).NotDefault());
            Assert.IsFalse(default(uint?).NotDefault());
        }

        [TestMethod]
        public void Long()
        {
            var @long = (long)123;
            var @ulong = (ulong)123;

            // long
            Assert.IsTrue(@long.NotDefault());
            Assert.IsFalse(default(long).NotDefault());

            // ulong
            Assert.IsTrue(@ulong.NotDefault());
            Assert.IsFalse(default(ulong).NotDefault());

            // long?
            Assert.IsTrue((@long as long?).NotDefault());
            Assert.IsFalse(default(long?).NotDefault());

            // ulong?
            Assert.IsTrue((@ulong as ulong?).NotDefault());
            Assert.IsFalse(default(ulong?).NotDefault());
        }

        [TestMethod]
        public void Float()
        {
            var @float = (float)12.3;

            // float
            Assert.IsTrue(@float.NotDefault());
            Assert.IsFalse(default(float).NotDefault());

            // float?
            Assert.IsTrue((@float as float?).NotDefault());
            Assert.IsFalse(default(float?).NotDefault());
        }

        [TestMethod]
        public void Double()
        {
            var @double = 12.3;

            // double
            Assert.IsTrue(@double.NotDefault());
            Assert.IsFalse(default(double).NotDefault());

            // double
            Assert.IsTrue((@double as double?).NotDefault());
            Assert.IsFalse(default(double?).NotDefault());
        }

        [TestMethod]
        public void Decimal()
        {
            var @decimal = (decimal)12.3;

            // decimal
            Assert.IsTrue(@decimal.NotDefault());
            Assert.IsFalse(default(decimal).NotDefault());

            // decimal?
            Assert.IsTrue((@decimal as decimal?).NotDefault());
            Assert.IsFalse(default(decimal?).NotDefault());
        }

        [TestMethod]
        public void Char()
        {
            var @char = 's';

            // char
            Assert.IsTrue(@char.NotDefault());
            Assert.IsFalse(default(char).NotDefault());

            // char?
            Assert.IsTrue((@char as char?).NotDefault());
            Assert.IsFalse(default(char?).NotDefault());
        }

        [TestMethod]
        public void String()
        {
            var @string = "string";

            Assert.IsTrue(@string.NotDefault());
            Assert.IsFalse(default(string).NotDefault());
        }

        [TestMethod]
        public void Bool()
        {
            var @bool = true;

            Assert.IsTrue(@bool.NotDefault());
            Assert.IsFalse(default(bool).NotDefault());
        }

        [TestMethod]
        public void Object()
        {
            var @object = (object)new { Foo = "Bar" };

            Assert.IsTrue(@object.NotDefault());
            Assert.IsFalse(default(object).NotDefault());
        }
    }
}
