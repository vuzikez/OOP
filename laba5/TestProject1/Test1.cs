using System.Text;
using StrBuilderIPv4;

namespace TestProject1
{
    [TestClass]
    public class StrBuilderIPTests
    {
        [TestMethod]
        public void SortIpv4_ValidAddresses_ReturnsSortedByClass()
        {
            // Arrange
            var builder = new StrBuilderIP();
            var sb = new StringBuilder("192.168.1.1 10.0.0.1 172.16.0.1");

            // Act
            var result = builder.SortIpv4(sb);

            // Assert
            Assert.AreEqual(6, result.Count); // A, B, C, D, E, U
            Assert.AreEqual(1, result['A'].Count);
            Assert.AreEqual(1, result['B'].Count);
            Assert.AreEqual(1, result['C'].Count);
            Assert.AreEqual("10.0.0.1", result['A'][0]);
            Assert.AreEqual("172.16.0.1", result['B'][0]);
            Assert.AreEqual("192.168.1.1", result['C'][0]);
        }

        [TestMethod]
        public void SortIpv4_WithInvalidAddresses_ReturnsOnlyValidByClass()
        {
            // Arrange
            var builder = new StrBuilderIP();
            var sb = new StringBuilder("192.168.1.1 256.256.256.256 10.0.0.1 300.400.500.600");

            // Act
            var result = builder.SortIpv4(sb);

            // Assert
            Assert.AreEqual(2, result['A'].Count + result['B'].Count + result['C'].Count + result['D'].Count + result['E'].Count + result['U'].Count);
            Assert.AreEqual(1, result['A'].Count);
            Assert.AreEqual(1, result['C'].Count);
            Assert.AreEqual("10.0.0.1", result['A'][0]);
            Assert.AreEqual("192.168.1.1", result['C'][0]);
        }

        [TestMethod]
        public void SortIpv4_WithOutOfRangeOctets_ReturnsOnlyValidRangeByClass()
        {
            // Arrange
            var builder = new StrBuilderIP();
            var sb = new StringBuilder("192.168.1.255 192.168.1.256 10.0.0.0 10.0.0.-1");

            // Act
            var result = builder.SortIpv4(sb);

            // Assert
            Assert.AreEqual(2, result['A'].Count + result['C'].Count);
            Assert.AreEqual(1, result['A'].Count);
            Assert.AreEqual(1, result['C'].Count);
            Assert.AreEqual("10.0.0.0", result['A'][0]);
            Assert.AreEqual("192.168.1.255", result['C'][0]);
        }

        [TestMethod]
        public void SortIpv4_EmptyStringBuilder_ReturnsEmptyClasses()
        {
            // Arrange
            var builder = new StrBuilderIP();
            var sb = new StringBuilder("");

            // Act
            var result = builder.SortIpv4(sb);

            // Assert
            Assert.AreEqual(0, result['A'].Count);
            Assert.AreEqual(0, result['B'].Count);
            Assert.AreEqual(0, result['C'].Count);
            Assert.AreEqual(0, result['D'].Count);
            Assert.AreEqual(0, result['E'].Count);
            Assert.AreEqual(0, result['U'].Count);
        }

        [TestMethod]
        public void SortIpv4_MixedValidAndInvalidFormats_ReturnsOnlyValidByClass()
        {
            // Arrange
            var builder = new StrBuilderIP();
            var sb = new StringBuilder("192.168.1.1 invalid 10.0.0.1 192.168.1 192.168.1.1.1");

            // Act
            var result = builder.SortIpv4(sb);

            // Assert
            Assert.AreEqual(2, result['A'].Count + result['C'].Count);
            Assert.AreEqual(1, result['A'].Count);
            Assert.AreEqual(1, result['C'].Count);
            Assert.AreEqual("10.0.0.1", result['A'][0]);
            Assert.AreEqual("192.168.1.1", result['C'][0]);
        }

        [TestMethod]
        public void SortIpv4_BoundaryValues_ReturnsValidAddressesByClass()
        {
            var builder = new StrBuilderIP();
            var sb = new StringBuilder("1.0.0.0 126.255.255.255 128.0.0.0 191.255.255.255 192.0.0.0 223.255.255.255 224.0.0.0 239.255.255.255 240.0.0.0 255.255.255.255");

            var result = builder.SortIpv4(sb);

            Assert.AreEqual(2, result['A'].Count);
            Assert.AreEqual(2, result['B'].Count);
            Assert.AreEqual(2, result['C'].Count);
            Assert.AreEqual(2, result['D'].Count);
            Assert.AreEqual(2, result['E'].Count);
            Assert.AreEqual(0, result['U'].Count);
        }

        [TestMethod]
        public void SortIpv4_DuplicateAddresses_ReturnsAllSortedByClass()
        {
            // Arrange
            var builder = new StrBuilderIP();
            var sb = new StringBuilder("192.168.1.1 10.0.0.1 192.168.1.1 10.0.0.1");

            // Act
            var result = builder.SortIpv4(sb);

            // Assert
            Assert.AreEqual(2, result['A'].Count);
            Assert.AreEqual(2, result['C'].Count);
            Assert.AreEqual("10.0.0.1", result['A'][0]);
            Assert.AreEqual("10.0.0.1", result['A'][1]);
            Assert.AreEqual("192.168.1.1", result['C'][0]);
            Assert.AreEqual("192.168.1.1", result['C'][1]);
        }

        [TestMethod]
        public void SortIpv4_AllClassesIncludingMulticast_ReturnsCorrectClassification()
        {
            // Arrange
            var builder = new StrBuilderIP();
            var sb = new StringBuilder("10.0.0.1 172.16.0.1 192.168.1.1 224.0.0.1 240.0.0.1 127.0.0.1");

            // Act
            var result = builder.SortIpv4(sb);

            // Assert
            Assert.AreEqual(1, result['A'].Count);
            Assert.AreEqual(1, result['B'].Count);
            Assert.AreEqual(1, result['C'].Count);
            Assert.AreEqual(1, result['D'].Count);
            Assert.AreEqual(1, result['E'].Count);
            Assert.AreEqual(1, result['U'].Count);
            Assert.AreEqual("10.0.0.1", result['A'][0]);
            Assert.AreEqual("172.16.0.1", result['B'][0]);
            Assert.AreEqual("192.168.1.1", result['C'][0]);
            Assert.AreEqual("224.0.0.1", result['D'][0]);
            Assert.AreEqual("240.0.0.1", result['E'][0]);
            Assert.AreEqual("127.0.0.1", result['U'][0]);
        }

        [TestMethod]
        public void SortIpv4_AddressesSortedWithinEachClass()
        {
            // Arrange
            var builder = new StrBuilderIP();
            var sb = new StringBuilder("192.168.1.10 192.168.1.1 10.20.0.1 10.10.0.1");

            // Act
            var result = builder.SortIpv4(sb);

            // Assert
            Assert.AreEqual("10.10.0.1", result['A'][0]);
            Assert.AreEqual("10.20.0.1", result['A'][1]);
            Assert.AreEqual("192.168.1.1", result['C'][0]);
            Assert.AreEqual("192.168.1.10", result['C'][1]);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CreateStr_EmptyInput_ThrowsException()
        {
            // Arrange
            var builder = new StrBuilderIP();
            var input = "";

            // Act & Assert
            using (var reader = new StringReader(input))
            {
                Console.SetIn(reader);
                builder.CreateStr();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CreateStr_NullInput_ThrowsException()
        {
            // Arrange
            var builder = new StrBuilderIP();
            string? input = null;

            // Act & Assert
            using (var reader = new StringReader(input ?? ""))
            {
                Console.SetIn(reader);
                builder.CreateStr();
            }
        }

        [TestMethod]
        public void GetIpClass_PrivateAddresses_ReturnsCorrectClasses()
        {
            // Arrange
            var builder = new StrBuilderIP();
            var sb = new StringBuilder("10.0.0.1 172.16.0.1 192.168.1.1");

            // Act
            var result = builder.SortIpv4(sb);

            // Assert
            Assert.AreEqual(1, result['A'].Count);
            Assert.AreEqual(1, result['B'].Count);
            Assert.AreEqual(1, result['C'].Count);
        }

        [TestMethod]
        public void SortIpv4_NoValidAddresses_ReturnsEmptyLists()
        {
            // Arrange
            var builder = new StrBuilderIP();
            var sb = new StringBuilder("invalid text without ip addresses");

            // Act
            var result = builder.SortIpv4(sb);

            // Assert
            Assert.AreEqual(0, result['A'].Count);
            Assert.AreEqual(0, result['B'].Count);
            Assert.AreEqual(0, result['C'].Count);
            Assert.AreEqual(0, result['D'].Count);
            Assert.AreEqual(0, result['E'].Count);
            Assert.AreEqual(0, result['U'].Count);
        }
    }
}