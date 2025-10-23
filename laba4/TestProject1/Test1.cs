[TestClass]
public class StringApplicationTests
{
    [TestMethod]
    public void GetDiffSymbols_AllUnique_ReturnsCorrectCountAndSymbols()
    {
        var (count, symbols) = StringApplication.Program.GetDiffSymbols("abc");
        Assert.AreEqual(3, count);
        CollectionAssert.AreEquivalent(new List<char> { 'a', 'b', 'c' }, symbols);
    }

    [TestMethod]
    public void GetDiffSymbols_AllSame_ReturnsOneSymbol()
    {
        var (count, symbols) = StringApplication.Program.GetDiffSymbols("aaa");
        Assert.AreEqual(1, count);
        CollectionAssert.AreEquivalent(new List<char> { 'a' }, symbols);
    }

    [TestMethod]
    public void GetDiffSymbols_PartiallyUnique_ReturnsCorrectCountAndSymbols()
    {
        var (count, symbols) = StringApplication.Program.GetDiffSymbols("aab");
        Assert.AreEqual(2, count);
        CollectionAssert.AreEquivalent(new List<char> { 'a', 'b' }, symbols);
    }

    [TestMethod]
    public void GetDiffSymbols_ComplexString_ReturnsCorrectCountAndSymbols()
    {
        var (count, symbols) = StringApplication.Program.GetDiffSymbols("abracadabra");
        Assert.AreEqual(5, count); // a, b, r, c, d
        CollectionAssert.AreEquivalent(new List<char> { 'a', 'b', 'r', 'c', 'd' }, symbols);
    }

    [TestMethod]
    public void GetDiffSymbols_SingleChar_ReturnsOneSymbol()
    {
        var (count, symbols) = StringApplication.Program.GetDiffSymbols("X");
        Assert.AreEqual(1, count);
        CollectionAssert.AreEquivalent(new List<char> { 'X' }, symbols);
    }

    [TestMethod]
    public void GetDiffSymbols_EmptyString_ReturnsZeroAndEmptyList()
    {
        var (count, symbols) = StringApplication.Program.GetDiffSymbols("");
        Assert.AreEqual(0, count);
        Assert.AreEqual(0, symbols.Count);
    }

    [TestMethod]
    public void GetDiffSymbols_WithSpaces_CountsSpaces()
    {
        var (count, symbols) = StringApplication.Program.GetDiffSymbols("a a b");
        Assert.AreEqual(3, count);
        CollectionAssert.AreEquivalent(new List<char> { 'a', ' ', 'b' }, symbols);
    }

    [TestMethod]
    public void GetDiffSymbols_SpecialCharacters_ReturnsCorrectCountAndSymbols()
    {
        var (count, symbols) = StringApplication.Program.GetDiffSymbols("a!b!c");
        Assert.AreEqual(4, count); // a, !, b, c
        CollectionAssert.AreEquivalent(new List<char> { 'a', '!', 'b', 'c' }, symbols);
    }

    [TestMethod]
    public void GetDiffSymbols_MixedCase_CountsUpperCaseAndLowerCaseAsDifferent()
    {
        var (count, symbols) = StringApplication.Program.GetDiffSymbols("AaBb");
        Assert.AreEqual(4, count);
        CollectionAssert.AreEquivalent(new List<char> { 'A', 'a', 'B', 'b' }, symbols);
    }

    [TestMethod]
    public void GetDiffSymbols_NumbersAndLetters_ReturnsCorrectSymbols()
    {
        var (count, symbols) = StringApplication.Program.GetDiffSymbols("a1b2a1");
        Assert.AreEqual(4, count);
        CollectionAssert.AreEquivalent(new List<char> { 'a', '1', 'b', '2' }, symbols);
    }

    [TestMethod]
    public void GetDiffSymbols_StringWithNewline_CountsNewlineAsSymbol()
    {
        var (count, symbols) = StringApplication.Program.GetDiffSymbols("a\nb");
        Assert.AreEqual(3, count);
        CollectionAssert.AreEquivalent(new List<char> { 'a', '\n', 'b' }, symbols);
    }

    [TestMethod]
    public void GetDiffSymbols_UnicodeCharacters_WorksCorrectly()
    {
        var (count, symbols) = StringApplication.Program.GetDiffSymbols("привет");
        Assert.AreEqual(6, count);
        CollectionAssert.AreEquivalent(new List<char> { 'п', 'р', 'и', 'в', 'е', 'т' }, symbols);
    }

    [TestMethod]
    public void GetDiffSymbols_DuplicateCharactersInDifferentOrder_ReturnsUniqueSymbols()
    {
        var (count, symbols) = StringApplication.Program.GetDiffSymbols("abcba");
        Assert.AreEqual(3, count);
        CollectionAssert.AreEquivalent(new List<char> { 'a', 'b', 'c' }, symbols);
    }

    [TestMethod]
    public void GetDiffSymbols_StringWithTabs_CountsTabAsSymbol()
    {
        var (count, symbols) = StringApplication.Program.GetDiffSymbols("a\tb");
        Assert.AreEqual(3, count);
        CollectionAssert.AreEquivalent(new List<char> { 'a', '\t', 'b' }, symbols);
    }

    [TestMethod]
    public void GetDiffSymbols_LongStringWithManyDuplicates_ReturnsCorrectUniqueCount()
    {
        var (count, symbols) = StringApplication.Program.GetDiffSymbols("mississippi");
        Assert.AreEqual(4, count); // m, i, s, p
        CollectionAssert.AreEquivalent(new List<char> { 'm', 'i', 's', 'p' }, symbols);
    }
}