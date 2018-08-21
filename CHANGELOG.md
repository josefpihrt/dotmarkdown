## 0.1.0 (2018-08-21)

### New API

* Add method DotMarkdown.MarkdownWriter.WriteStartLink
* Add method DotMarkdown.MarkdownWriter.WriteEndLink
* Add method DotMarkdown.MarkdownWriter.WriteTableCell
* Add method DotMarkdown.TableColumnInfo.WithAlignment
* Add method DotMarkdown.TableColumnInfo.WithWidth
* Add method DotMarkdown.TableColumnInfo.WithIsWhiteSpace
* Add method DotMarkdown.Linq.MFactory.Autolink
* Add method DotMarkdown.Linq.MFactory.LinkOrAutolink

### Changed API

* Class DotMarkdown.Emojis is internal
* Class DotMarkdown.Linq.MLink inherits from DotMarkdown.Linq.MContainer instead of DotMarkdown.Linq.MElement

## 0.1.0-rc (2018-04-04)

### New API

* Add With... methods to MarkdownWriterSettings
* Add 1 overload for MarkdownWriter.Create method
* Add 2 overloads for MElement.Save method

### Bug Fixes

* Fix indentation of nested ordered item

## 0.1.0-beta (2018-01-30)

* Initial release