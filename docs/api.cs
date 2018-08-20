using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DotMarkdown
{
    public static class LanguageIdentifiers
    {
        public const string ABNF = "abnf";
        public const string ARMAssembler = "armasm";
        public const string AVRAssembler = "avrasm";
        public const string AccessLogs = "accesslog";
        public const string ActionScript = "actionscript";
        public const string Ada = "ada";
        public const string Apache = "apache";
        public const string AppleScript = "applescript";
        public const string AsciiDoc = "asciidoc";
        public const string AspectJ = "aspectj";
        public const string AutoHotkey = "autohotkey";
        public const string AutoIt = "autoit";
        public const string Awk = "awk";
        public const string Axapta = "axapta";
        public const string BNF = "bnf";
        public const string Bash = "bash";
        public const string Basic = "basic";
        public const string Brainfuck = "brainfuck";
        public const string C = "c";
        public const string CAL = "cal";
        public const string CMake = "cmake";
        public const string CSP = "csp";
        public const string CSS = "css";
        public const string CSharp = "csharp";
        public const string CacheObjectScript = "cos";
        public const string CapnProto = "capnp";
        public const string Clojure = "clojure";
        public const string CoffeeScript = "coffeescript";
        public const string Coq = "coq";
        public const string Cpp = "cpp";
        public const string Crmsh = "crmsh";
        public const string Crystal = "crystal";
        public const string D = "d";
        public const string DNSZoneFile = "dns";
        public const string DOS = "dos";
        public const string DTS = "dts";
        public const string Dart = "dart";
        public const string Delphi = "delphi";
        public const string Diff = "diff";
        public const string Django = "django";
        public const string Dockerfile = "docker";
        public const string Dsconfig = "dsconfig";
        public const string Dust = "dust";
        public const string EBNF = "ebnf";
        public const string Elixir = "elixir";
        public const string Elm = "elm";
        public const string Erlang = "erlang";
        public const string Excel = "excel";
        public const string FIX = "fix";
        public const string FSharp = "fsharp";
        public const string Fortran = "fortran";
        public const string GAUSS = "gauss";
        public const string GCode = "gcode";
        public const string Gams = "gams";
        public const string Gherkin = "gherkin";
        public const string Go = "go";
        public const string Golo = "golo";
        public const string Gradle = "gradle";
        public const string Groovy = "groovy";
        public const string HTML = "html";
        public const string HTTP = "http";
        public const string Haml = "haml";
        public const string Handlebars = "handlebars";
        public const string Haskell = "haskell";
        public const string Haxe = "haxe";
        public const string Hy = "hy";
        public const string IRPF90 = "irpf90";
        public const string Inform7 = "inform7";
        public const string Ini = "ini";
        public const string JSON = "json";
        public const string Java = "java";
        public const string JavaScript = "javascript";
        public const string LDIF = "ldif";
        public const string Lasso = "lasso";
        public const string Leaf = "leaf";
        public const string Less = "less";
        public const string Lisp = "lisp";
        public const string LiveCodeServer = "livecodeserver";
        public const string LiveScript = "livescript";
        public const string Lua = "lua";
        public const string Makefile = "makefile";
        public const string Markdown = "markdown";
        public const string Mathematica = "mathematica";
        public const string Matlab = "matlab";
        public const string Maxima = "maxima";
        public const string MayaEmbeddedLanguage = "mel";
        public const string Mercury = "mercury";
        public const string Mizar = "mizar";
        public const string Mojolicious = "mojolicious";
        public const string Monkey = "monkey";
        public const string Moonscript = "moonscript";
        public const string N1QL = "n1ql";
        public const string NSIS = "nsis";
        public const string Nginx = "nginx";
        public const string Nimrod = "nimrod";
        public const string Nix = "nix";
        public const string OCaml = "ocaml";
        public const string ObjectiveC = "objectivec";
        public const string OpenGLShadingLanguage = "glsl";
        public const string OpenSCAD = "openscad";
        public const string OracleRulesLanguage = "ruleslanguage";
        public const string Oxygene = "oxygene";
        public const string PF = "pf";
        public const string PHP = "php";
        public const string Parser3 = "parser3";
        public const string Perl = "perl";
        public const string Pony = "pony";
        public const string PowerShell = "powershell";
        public const string Processing = "processing";
        public const string Prolog = "prolog";
        public const string ProtocolBuffers = "protobuf";
        public const string Puppet = "puppet";
        public const string Python = "python";
        public const string PythonProfilerResults = "profile";
        public const string Q = "k";
        public const string QML = "qml";
        public const string R = "r";
        public const string RenderManRIB = "rib";
        public const string RenderManRSL = "rsl";
        public const string Roboconf = "graph";
        public const string Ruby = "ruby";
        public const string Rust = "rust";
        public const string SCSS = "scss";
        public const string SQL = "sql";
        public const string STEPPart21 = "step";
        public const string Scala = "scala";
        public const string Scheme = "scheme";
        public const string Scilab = "scilab";
        public const string Shell = "shell";
        public const string Smali = "smali";
        public const string Smalltalk = "smalltalk";
        public const string Stan = "stan";
        public const string Stata = "stata";
        public const string Stylus = "stylus";
        public const string SubUnit = "subunit";
        public const string Swift = "swift";
        public const string TP = "tp";
        public const string Tcl = "tcl";
        public const string TeX = "tex";
        public const string TestAnythingProtocol = "tap";
        public const string Thrift = "thrift";
        public const string Twig = "twig";
        public const string TypeScript = "typescript";
        public const string VBScript = "vbscript";
        public const string VHDL = "vhdl";
        public const string Vala = "vala";
        public const string Verilog = "verilog";
        public const string VimScript = "vim";
        public const string VisualBasic = "vb";
        public const string X86Assembly = "x86asm";
        public const string XL = "xl";
        public const string XML = "xml";
        public const string XQuery = "xpath";
        public const string Zephir = "zephir";
    }

    public static class MarkdownEscaper
    {
        public static string Escape(string value, Func<char, bool> shouldBeEscaped = null);
        public static bool ShouldBeEscaped(char value);
    }

    public class MarkdownFormat : IEquatable<MarkdownFormat>
    {
        public MarkdownFormat(EmphasisStyle boldStyle = EmphasisStyle.Asterisk, EmphasisStyle italicStyle = EmphasisStyle.Asterisk, BulletListStyle bulletListStyle = BulletListStyle.Asterisk, OrderedListStyle orderedListStyle = OrderedListStyle.Dot, HeadingStyle headingStyle = HeadingStyle.NumberSign, HeadingOptions headingOptions = HeadingOptions.EmptyLineBeforeAndAfter, TableOptions tableOptions = TableOptions.FormatHeader | TableOptions.Padding | TableOptions.OuterDelimiter | TableOptions.EmptyLineBeforeAndAfter, CodeFenceStyle codeFenceStyle = CodeFenceStyle.Backtick, CodeBlockOptions codeBlockOptions = CodeBlockOptions.EmptyLineBeforeAndAfter, CharEntityFormat charEntityFormat = CharEntityFormat.Hexadecimal, HorizontalRuleFormat? horizontalRuleFormat = null);

        public EmphasisStyle BoldStyle { get; }
        public BulletListStyle BulletListStyle { get; }
        public CharEntityFormat CharEntityFormat { get; }
        public CodeBlockOptions CodeBlockOptions { get; }
        public CodeFenceStyle CodeFenceStyle { get; }
        public static MarkdownFormat Default { get; }
        public HeadingOptions HeadingOptions { get; }
        public HeadingStyle HeadingStyle { get; }
        public HorizontalRuleFormat HorizontalRuleFormat { get; }
        public EmphasisStyle ItalicStyle { get; }
        public OrderedListStyle OrderedListStyle { get; }
        public TableOptions TableOptions { get; }

        public bool Equals(MarkdownFormat other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public MarkdownFormat WithBoldStyle(EmphasisStyle boldStyle);
        public MarkdownFormat WithBulletListStyle(BulletListStyle bulletListStyle);
        public MarkdownFormat WithCharEntityFormat(CharEntityFormat charEntityFormat);
        public MarkdownFormat WithCodeBlockOptions(CodeBlockOptions codeBlockOptions);
        public MarkdownFormat WithCodeFenceStyle(CodeFenceStyle codeFenceStyle);
        public MarkdownFormat WithHeadingOptions(HeadingOptions headingOptions);
        public MarkdownFormat WithHeadingOptions(HeadingStyle headingStyle);
        public MarkdownFormat WithHorizontalRuleFormat(in HorizontalRuleFormat horizontalRuleFormat);
        public MarkdownFormat WithItalicStyle(EmphasisStyle italicStyle);
        public MarkdownFormat WithOrderedListStyle(OrderedListStyle orderedListStyle);
        public MarkdownFormat WithTableOptions(TableOptions tableOptions);

        public static bool operator ==(MarkdownFormat format1, MarkdownFormat format2);
        public static bool operator !=(MarkdownFormat format1, MarkdownFormat format2);
    }

    public abstract class MarkdownWriter : IDisposable
    {
        protected MarkdownWriter(MarkdownWriterSettings settings = null);

        public MarkdownFormat Format { get; }
        public virtual MarkdownWriterSettings Settings { get; }
        public abstract WriteState WriteState { get; }

        public virtual void Close();
        public static MarkdownWriter Create(Stream stream, Encoding encoding, MarkdownWriterSettings settings = null);
        public static MarkdownWriter Create(Stream stream, MarkdownWriterSettings settings = null);
        public static MarkdownWriter Create(StringBuilder output, IFormatProvider formatProvider, MarkdownWriterSettings settings = null);
        public static MarkdownWriter Create(StringBuilder output, MarkdownWriterSettings settings = null);
        public static MarkdownWriter Create(TextWriter output, MarkdownWriterSettings settings = null);
        public void Dispose();
        protected virtual void Dispose(bool disposing);
        public abstract void Flush();
        public abstract void WriteAutolink(string url);
        public virtual void WriteBlockQuote(string text);
        public virtual void WriteBold(string text);
        public virtual void WriteBulletItem(string text);
        public abstract void WriteCharEntity(char value);
        public abstract void WriteComment(string text);
        public void WriteCompletedTaskItem(string text);
        public abstract void WriteEndBlockQuote();
        public abstract void WriteEndBold();
        public abstract void WriteEndBulletItem();
        public abstract void WriteEndHeading();
        public abstract void WriteEndItalic();
        public abstract void WriteEndLink(string url, string title = null);
        public abstract void WriteEndOrderedItem();
        public abstract void WriteEndStrikethrough();
        public abstract void WriteEndTable();
        public abstract void WriteEndTableCell();
        public abstract void WriteEndTableRow();
        public abstract void WriteEndTaskItem();
        public abstract void WriteEntityRef(string name);
        public abstract void WriteFencedCodeBlock(string text, string info = null);
        public virtual void WriteHeading(int level, string text);
        public void WriteHeading1(string text);
        public void WriteHeading2(string text);
        public void WriteHeading3(string text);
        public void WriteHeading4(string text);
        public void WriteHeading5(string text);
        public void WriteHeading6(string text);
        public void WriteHorizontalRule();
        public abstract void WriteHorizontalRule(HorizontalRuleStyle style, int count = 3, string separator = " ");
        public void WriteHorizontalRule(in HorizontalRuleFormat format);
        public abstract void WriteImage(string text, string url, string title = null);
        public abstract void WriteImageReference(string text, string label);
        public abstract void WriteIndentedCodeBlock(string text);
        public abstract void WriteInlineCode(string text);
        public virtual void WriteItalic(string text);
        public abstract void WriteLabel(string label, string url, string title = null);
        public abstract void WriteLine();
        public virtual void WriteLink(string text, string url, string title = null);
        public void WriteLinkOrText(string text, string url = null, string title = null);
        public abstract void WriteLinkReference(string text, string label = null);
        public virtual void WriteOrderedItem(int number, string text);
        public abstract void WriteRaw(string data);
        public abstract void WriteStartBlockQuote();
        public abstract void WriteStartBold();
        public abstract void WriteStartBulletItem();
        public void WriteStartCompletedTaskItem();
        public abstract void WriteStartHeading(int level);
        public abstract void WriteStartItalic();
        public abstract void WriteStartLink();
        public abstract void WriteStartOrderedItem(int number);
        public abstract void WriteStartStrikethrough();
        public abstract void WriteStartTable(IReadOnlyList<TableColumnInfo> columns);
        public abstract void WriteStartTable(int columnCount);
        public abstract void WriteStartTableCell();
        public abstract void WriteStartTableRow();
        public abstract void WriteStartTaskItem(bool isCompleted = false);
        public virtual void WriteStrikethrough(string text);
        public abstract void WriteString(string text);
        public virtual void WriteTableCell(string text);
        public abstract void WriteTableHeaderSeparator();
        public virtual void WriteTaskItem(string text, bool isCompleted = false);
        public virtual void WriteValue(bool value);
        public virtual void WriteValue(decimal value);
        public virtual void WriteValue(double value);
        public virtual void WriteValue(float value);
        public virtual void WriteValue(int value);
        public virtual void WriteValue(long value);
    }

    public class MarkdownWriterSettings
    {
        public MarkdownWriterSettings(MarkdownFormat format = null, string newLineChars = null, NewLineHandling newLineHandling = NewLineHandling.Replace, bool closeOutput = false);

        public bool CloseOutput { get; }
        public static MarkdownWriterSettings Default { get; }
        public MarkdownFormat Format { get; }
        public string NewLineChars { get; }
        public NewLineHandling NewLineHandling { get; }

        public MarkdownWriterSettings WithCloseOutput(bool closeOutput);
        public MarkdownWriterSettings WithFormat(MarkdownFormat format);
        public MarkdownWriterSettings WithNewLineChars(string newLineChars);
        public MarkdownWriterSettings WithNewLineHandling(NewLineHandling newLineHandling);
    }

    public readonly struct HorizontalRuleFormat : IEquatable<HorizontalRuleFormat>
    {
        public HorizontalRuleFormat(HorizontalRuleStyle style, int count, string separator);

        public int Count { get; }
        public static HorizontalRuleFormat Default { get; }
        public bool IsValid { get; }
        public string Separator { get; }
        public HorizontalRuleStyle Style { get; }

        public bool Equals(HorizontalRuleFormat other);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(in HorizontalRuleFormat format1, in HorizontalRuleFormat format2);
        public static bool operator !=(in HorizontalRuleFormat format1, in HorizontalRuleFormat format2);
    }

    public readonly struct TableColumnInfo : IEquatable<TableColumnInfo>
    {
        public TableColumnInfo(HorizontalAlignment alignment, int width, bool isWhiteSpace);

        public HorizontalAlignment Alignment { get; }
        public bool IsWhiteSpace { get; }
        public int Width { get; }

        public bool Equals(TableColumnInfo other);
        public override bool Equals(object obj);
        public override int GetHashCode();
        public TableColumnInfo WithAlignment(HorizontalAlignment alignment);
        public TableColumnInfo WithIsWhiteSpace(bool isWhiteSpace);
        public TableColumnInfo WithWidth(int width);

        public static bool operator ==(in TableColumnInfo info1, in TableColumnInfo info2);
        public static bool operator !=(in TableColumnInfo info1, in TableColumnInfo info2);
    }

    public enum BulletListStyle
    {
        Asterisk = 0,
        Plus = 1,
        Minus = 2,
    }

    [Flags]
    public enum CodeBlockOptions
    {
        None = 0,
        EmptyLineBefore = 1,
        EmptyLineAfter = 2,
        EmptyLineBeforeAndAfter = EmptyLineBefore | EmptyLineAfter,
    }

    public enum CodeFenceStyle
    {
        Backtick = 0,
        Tilde = 1,
    }

    public enum EmphasisStyle
    {
        Asterisk = 0,
        Underscore = 1,
    }

    [Flags]
    public enum HeadingOptions
    {
        None = 0,
        UnderlineHeading1 = 1,
        UnderlineHeading2 = 2,
        Underline = UnderlineHeading1 | UnderlineHeading2,
        Close = 4,
        EmptyLineBefore = 8,
        EmptyLineAfter = 16,
        EmptyLineBeforeAndAfter = EmptyLineBefore | EmptyLineAfter,
    }

    public enum HeadingStyle
    {
        NumberSign = 0,
    }

    public enum HorizontalAlignment
    {
        Left = 0,
        Center = 1,
        Right = 2,
    }

    public enum HorizontalRuleStyle
    {
        Hyphen = 0,
        Underscore = 1,
        Asterisk = 2,
    }

    public enum CharEntityFormat
    {
        Hexadecimal = 0,
        Decimal = 1,
    }

    public enum MarkdownKind
    {
        None = 0,
        Text = 1,
        Raw = 2,
        Link = 3,
        LinkReference = 4,
        Image = 5,
        ImageReference = 6,
        Label = 7,
        Autolink = 8,
        InlineCode = 9,
        CharEntity = 10,
        EntityRef = 11,
        Comment = 12,
        FencedCodeBlock = 13,
        IndentedCodeBlock = 14,
        HorizontalRule = 15,
        Heading = 16,
        Inline = 17,
        Bold = 18,
        Italic = 19,
        Strikethrough = 20,
        Table = 21,
        TableRow = 22,
        TableColumn = 23,
        BulletList = 24,
        OrderedList = 25,
        TaskList = 26,
        BulletItem = 27,
        OrderedItem = 28,
        TaskItem = 29,
        BlockQuote = 30,
        Document = 31,
    }

    public enum NewLineHandling
    {
        Replace = 0,
        None = 1,
    }

    public enum OrderedListStyle
    {
        Dot = 0,
        Parenthesis = 1,
    }

    [Flags]
    public enum TableOptions
    {
        None = 0,
        FormatHeader = 1,
        FormatContent = 2,
        FormatHeaderAndContent = FormatHeader | FormatContent,
        Padding = 4,
        OuterDelimiter = 8,
        EmptyLineBefore = 16,
        EmptyLineAfter = 32,
        EmptyLineBeforeAndAfter = EmptyLineBefore | EmptyLineAfter,
    }

    public enum WriteState
    {
        Start = 0,
        Content = 1,
        Closed = 2,
        Error = 3,
    }
}

namespace DotMarkdown.Linq
{
    public class MAutolink : MElement
    {
        public MAutolink(MAutolink other);
        public MAutolink(string url);

        public override MarkdownKind Kind { get; }
        public string Url { get; set; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public abstract class MBlockContainer : MContainer
    {
        protected MBlockContainer();
        protected MBlockContainer(MBlockContainer other);
        protected MBlockContainer(object content);
        protected MBlockContainer(params object[] content);
    }

    public class MBlockQuote : MBlockContainer
    {
        public MBlockQuote();
        public MBlockQuote(MBlockQuote other);
        public MBlockQuote(object content);
        public MBlockQuote(params object[] content);

        public override MarkdownKind Kind { get; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public class MBold : MInline
    {
        public MBold();
        public MBold(MBold other);
        public MBold(object content);
        public MBold(params object[] content);

        public override MarkdownKind Kind { get; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public class MBulletItem : MBlockContainer
    {
        public MBulletItem();
        public MBulletItem(MBulletItem other);
        public MBulletItem(object content);
        public MBulletItem(params object[] content);

        public override MarkdownKind Kind { get; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public class MBulletList : MList
    {
        public MBulletList();
        public MBulletList(MBulletList other);
        public MBulletList(object content);
        public MBulletList(params object[] content);

        public override MarkdownKind Kind { get; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public class MComment : MElement
    {
        public MComment(MComment other);
        public MComment(string value);

        public override MarkdownKind Kind { get; }
        public string Value { get; set; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public abstract class MContainer : MElement
    {
        protected MContainer();
        protected MContainer(MContainer other);
        protected MContainer(object content);
        protected MContainer(params object[] content);

        public MElement FirstElement { get; }
        public bool IsEmpty { get; }
        public MElement LastElement { get; }

        public void Add(object content);
        public void Add(params object[] content);
        public IEnumerable<MContainer> AncestorsAndSelf();
        public IEnumerable<MElement> Descendants();
        public IEnumerable<MElement> DescendantsAndSelf();
        public IEnumerable<MElement> Elements();
        public void RemoveAll();
    }

    public class MDocument : MBlockContainer
    {
        public MDocument();
        public MDocument(MDocument other);
        public MDocument(object content);
        public MDocument(params object[] content);

        public override MarkdownKind Kind { get; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public abstract class MElement : MObject
    {
        protected MElement();

        public MElement NextElement { get; }
        public MElement PreviousElement { get; }

        public IEnumerable<MContainer> Ancestors();
        public IEnumerable<MElement> ElementsAfterSelf();
        public IEnumerable<MElement> ElementsBeforeSelf();
        public void Remove();
        public void Save(MarkdownWriter writer);
        public void Save(Stream stream, MarkdownFormat format = null);
        public void Save(TextWriter writer, MarkdownFormat format = null);
        public void Save(string fileName, MarkdownFormat format = null);
        public override string ToString();
        public string ToString(MarkdownFormat format);
        public string ToString(MarkdownWriterSettings settings);
        public abstract void WriteTo(MarkdownWriter writer);
    }

    public class MEntityRef : MElement
    {
        public MEntityRef(MEntityRef other);
        public MEntityRef(string name);

        public override MarkdownKind Kind { get; }
        public string Name { get; set; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public static class MFactory
    {
        public static MEntityRef Ampersand();
        public static MAutolink Autolink(MAutolink other);
        public static MAutolink Autolink(string url);
        public static MBlockQuote BlockQuote();
        public static MBlockQuote BlockQuote(MBlockQuote other);
        public static MBlockQuote BlockQuote(object content);
        public static MBlockQuote BlockQuote(params object[] content);
        public static MBold Bold();
        public static MBold Bold(MBold other);
        public static MBold Bold(object content);
        public static MBold Bold(params object[] content);
        public static MBulletItem BulletItem();
        public static MBulletItem BulletItem(MBulletItem other);
        public static MBulletItem BulletItem(object content);
        public static MBulletItem BulletItem(params object[] content);
        public static MBulletList BulletList();
        public static MBulletList BulletList(MBulletList other);
        public static MBulletList BulletList(object content);
        public static MBulletList BulletList(params object[] content);
        public static MCharEntity CharEntity(MCharEntity other);
        public static MCharEntity CharEntity(char value);
        public static MTaskItem CompletedTaskItem();
        public static MTaskItem CompletedTaskItem(object content);
        public static MTaskItem CompletedTaskItem(params object[] content);
        public static MDocument Document();
        public static MDocument Document(MDocument other);
        public static MDocument Document(object content);
        public static MDocument Document(params object[] content);
        public static MEntityRef DoubleQuote();
        public static MEntityRef EntityRef(MEntityRef other);
        public static MEntityRef EntityRef(string name);
        public static MFencedCodeBlock FencedCodeBlock(MFencedCodeBlock other);
        public static MFencedCodeBlock FencedCodeBlock(string value, string info = null);
        public static MEntityRef GreaterThan();
        public static MHeading Heading(MHeading other);
        public static MHeading Heading(int level);
        public static MHeading Heading(int level, object content);
        public static MHeading Heading(int level, params object[] content);
        public static MHeading Heading1();
        public static MHeading Heading1(object content);
        public static MHeading Heading1(params object[] content);
        public static MHeading Heading2();
        public static MHeading Heading2(object content);
        public static MHeading Heading2(params object[] content);
        public static MHeading Heading3();
        public static MHeading Heading3(object content);
        public static MHeading Heading3(params object[] content);
        public static MHeading Heading4();
        public static MHeading Heading4(object content);
        public static MHeading Heading4(params object[] content);
        public static MHeading Heading5();
        public static MHeading Heading5(object content);
        public static MHeading Heading5(params object[] content);
        public static MHeading Heading6();
        public static MHeading Heading6(object content);
        public static MHeading Heading6(params object[] content);
        public static MHorizontalRule HorizontalRule();
        public static MHorizontalRule HorizontalRule(HorizontalRuleStyle style, int count = 3, string separator = " ");
        public static MHorizontalRule HorizontalRule(in HorizontalRuleFormat format);
        public static MImage Image(MImage other);
        public static MImage Image(string text, string url, string title = null);
        public static MIndentedCodeBlock IndentedCodeBlock(MIndentedCodeBlock other);
        public static MIndentedCodeBlock IndentedCodeBlock(string value);
        public static MInline Inline();
        public static MInline Inline(MInline other);
        public static MInline Inline(object content);
        public static MInline Inline(params object[] content);
        public static MInlineCode InlineCode(MInlineCode other);
        public static MInlineCode InlineCode(string text);
        public static MItalic Italic();
        public static MItalic Italic(MItalic other);
        public static MItalic Italic(object content);
        public static MItalic Italic(params object[] content);
        public static MInline Join(object separator, IEnumerable<object> values);
        public static MInline Join(object separator, params object[] values);
        public static MEntityRef LessThan();
        public static MLink Link(MLink other);
        public static MLink Link(object content, string url, string title = null);
        public static MElement LinkOrAutolink(string text, string url, string title = null);
        public static MElement LinkOrText(string text, string url, string title = null);
        public static MEntityRef NonBreakingSpace();
        public static MOrderedItem OrderedItem(MOrderedItem other);
        public static MOrderedItem OrderedItem(int number);
        public static MOrderedItem OrderedItem(int number, object content);
        public static MOrderedItem OrderedItem(int number, params object[] content);
        public static MOrderedList OrderedList();
        public static MOrderedList OrderedList(MOrderedList other);
        public static MOrderedList OrderedList(object content);
        public static MOrderedList OrderedList(params object[] content);
        public static MRaw Raw(MRaw other);
        public static MRaw Raw(string text);
        public static MEntityRef SingleQuote();
        public static MStrikethrough Strikethrough();
        public static MStrikethrough Strikethrough(MStrikethrough other);
        public static MStrikethrough Strikethrough(object content);
        public static MStrikethrough Strikethrough(params object[] content);
        public static MTable Table();
        public static MTable Table(MTable other);
        public static MTable Table(object content);
        public static MTable Table(params object[] content);
        public static MTableColumn TableColumn(HorizontalAlignment alignment);
        public static MTableColumn TableColumn(HorizontalAlignment alignment, object content);
        public static MTableColumn TableColumn(HorizontalAlignment alignment, params object[] content);
        public static MTableColumn TableColumn(MTableColumn other);
        public static MTableRow TableRow();
        public static MTableRow TableRow(MTableRow other);
        public static MTableRow TableRow(object content);
        public static MTableRow TableRow(params object[] content);
        public static MTaskItem TaskItem(MTaskItem other);
        public static MTaskItem TaskItem(bool isCompleted);
        public static MTaskItem TaskItem(bool isCompleted, object content);
        public static MTaskItem TaskItem(bool isCompleted, params object[] content);
        public static MTaskList TaskList();
        public static MTaskList TaskList(MTaskList other);
        public static MTaskList TaskList(object content);
        public static MTaskList TaskList(params object[] content);
    }

    public class MFencedCodeBlock : MElement
    {
        public MFencedCodeBlock(MFencedCodeBlock other);
        public MFencedCodeBlock(string text, string info = null);

        public string Info { get; set; }
        public override MarkdownKind Kind { get; }
        public string Text { get; set; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public class MHeading : MContainer
    {
        public MHeading(MHeading other);
        public MHeading(int level);
        public MHeading(int level, object content);
        public MHeading(int level, params object[] content);

        public override MarkdownKind Kind { get; }
        public int Level { get; set; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public class MHorizontalRule : MElement
    {
        public MHorizontalRule(HorizontalRuleStyle style, int count, string separator);
        public MHorizontalRule(MHorizontalRule other);
        public MHorizontalRule(in HorizontalRuleFormat format);

        public int Count { get; set; }
        public override MarkdownKind Kind { get; }
        public string Separator { get; set; }
        public HorizontalRuleStyle Style { get; set; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public class MCharEntity : MElement
    {
        public MCharEntity(MCharEntity other);
        public MCharEntity(char value);

        public override MarkdownKind Kind { get; }
        public char Value { get; set; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public class MImage : MElement
    {
        public MImage(MImage other);
        public MImage(string text, string url, string title = null);

        public override MarkdownKind Kind { get; }
        public string Text { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public class MIndentedCodeBlock : MElement
    {
        public MIndentedCodeBlock(MIndentedCodeBlock other);
        public MIndentedCodeBlock(string text);

        public override MarkdownKind Kind { get; }
        public string Text { get; set; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public class MInline : MContainer
    {
        public MInline();
        public MInline(MContainer other);
        public MInline(object content);
        public MInline(params object[] content);

        public override MarkdownKind Kind { get; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public class MInlineCode : MElement
    {
        public MInlineCode(MInlineCode other);
        public MInlineCode(string text);

        public override MarkdownKind Kind { get; }
        public string Text { get; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public class MItalic : MInline
    {
        public MItalic();
        public MItalic(MItalic other);
        public MItalic(object content);
        public MItalic(params object[] content);

        public override MarkdownKind Kind { get; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public class MLabel : MElement
    {
        public MLabel(MLabel other);
        public MLabel(string text, string url, string title = null);

        public override MarkdownKind Kind { get; }
        public string Text { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public class MLink : MContainer
    {
        public MLink(MLink other);
        public MLink(object content, string url, string title = null);

        public override MarkdownKind Kind { get; }
        public string Title { get; set; }
        public string Url { get; set; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public abstract class MList : MContainer
    {
        protected MList();
        protected MList(MList other);
        protected MList(object content);
        protected MList(params object[] content);
    }

    public abstract class MObject
    {
        protected MObject();

        public MDocument Document { get; }
        public abstract MarkdownKind Kind { get; }
        public MContainer Parent { get; }
    }

    public class MOrderedItem : MBlockContainer
    {
        public MOrderedItem(MOrderedItem other);
        public MOrderedItem(int number);
        public MOrderedItem(int number, object content);
        public MOrderedItem(int number, params object[] content);

        public override MarkdownKind Kind { get; }
        public int Number { get; set; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public class MOrderedList : MList
    {
        public MOrderedList();
        public MOrderedList(MOrderedList other);
        public MOrderedList(object content);
        public MOrderedList(params object[] content);

        public override MarkdownKind Kind { get; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public class MRaw : MElement
    {
        public MRaw(MRaw other);
        public MRaw(string value);

        public override MarkdownKind Kind { get; }
        public string Value { get; set; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public class MStrikethrough : MInline
    {
        public MStrikethrough();
        public MStrikethrough(MStrikethrough other);
        public MStrikethrough(object content);
        public MStrikethrough(params object[] content);

        public override MarkdownKind Kind { get; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public class MTable : MContainer
    {
        public MTable();
        public MTable(MContainer other);
        public MTable(object content);
        public MTable(params object[] content);

        public override MarkdownKind Kind { get; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public class MTableColumn : MContainer
    {
        public MTableColumn(HorizontalAlignment alignment);
        public MTableColumn(HorizontalAlignment alignment, object content);
        public MTableColumn(HorizontalAlignment alignment, params object[] content);
        public MTableColumn(MTableColumn other);

        public HorizontalAlignment Alignment { get; set; }
        public override MarkdownKind Kind { get; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public class MTableRow : MContainer
    {
        public MTableRow();
        public MTableRow(MTableRow other);
        public MTableRow(object content);
        public MTableRow(params object[] content);

        public override MarkdownKind Kind { get; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public class MTaskItem : MBlockContainer
    {
        public MTaskItem(MTaskItem other);
        public MTaskItem(bool isCompleted);
        public MTaskItem(bool isCompleted, object content);
        public MTaskItem(bool isCompleted, params object[] content);

        public bool IsCompleted { get; set; }
        public override MarkdownKind Kind { get; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public class MTaskList : MList
    {
        public MTaskList();
        public MTaskList(MTaskList other);
        public MTaskList(object content);
        public MTaskList(params object[] content);

        public override MarkdownKind Kind { get; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public class MText : MElement
    {
        public MText(MText other);
        public MText(string value);

        public override MarkdownKind Kind { get; }
        public string Value { get; set; }

        public override void WriteTo(MarkdownWriter writer);
    }

    public interface ITableAnalyzer
    {
        IReadOnlyList<TableColumnInfo> AnalyzeTable(IEnumerable<MElement> rows);
    }
}

