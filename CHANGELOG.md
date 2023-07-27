# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

## [0.3.0-beta] - 2023-07-27

### Added

- Add support for [Docusaurus markdown](https://docusaurus.io/docs/markdown-features) ([#28](https://github.com/josefpihrt/dotmarkdown/pull/28)).
- Add package symbols and Source Link ([#28](https://github.com/josefpihrt/dotmarkdown/pull/28)).

### Changed

- Enable nullable reference types ([#26](https://github.com/josefpihrt/dotmarkdown/pull/26)).
- Migrate documentation to [Docusaurus](https://josefpihrt.github.io/docs/dotmarkdown) ([#24](https://github.com/josefpihrt/dotmarkdown/pull/24)).
- Make class `Emojis` obsolete ([#31](https://github.com/josefpihrt/dotmarkdown/pull/31)).
 
### Fixed

- Handle fence inside fenced code block ([#31](https://github.com/josefpihrt/dotmarkdown/pull/31)).

## [0.2.0] - 2022-06-26

### Added

- Add NuGet readme file ([#17](https://github.com/josefpihrt/dotmarkdown/pull/17)).
- Add support for Source Link ([#18](https://github.com/josefpihrt/dotmarkdown/pull/18)).
- Add CI/CD pipeline ([#20](https://github.com/josefpihrt/dotmarkdown/pull/20)).

### Changed

- Escape both less than sign and greater than sign in the context where previously only latter was escaped ([#23](https://github.com/josefpihrt/dotmarkdown/pull/23)).
- Change target framework from .NET 4.5 to .NET 4.6.2 ([#20](https://github.com/josefpihrt/dotmarkdown/pull/20)).
- Migrate all scripts to PowerShell ([#19](https://github.com/josefpihrt/dotmarkdown/pull/19)).
- Add editorconfig and remove ruleset.
- Rename `master` to `main`.
- Format changelog according to 'Keep a Changelog'.

### Fixed

- Escape pipe inside inline code inside table ([#16](https://github.com/josefpihrt/dotmarkdown/issues/16)).
- Throw exception if number of row values exceeds number of columns.

-----

## 0.1.1 (2020-10-27)

* Add support for escaping angle brackets as `&lt;` and `&gt;` ([issue](https://github.com/JosefPihrt/DotMarkdown/issues/15))
* Add methods `MFactory.Label`
* Add overload `MarkdownWriter.Create(string, MarkdownWriterSettings)`

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