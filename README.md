# Pokemon Data Explorer


Pokemon Data Explorer is an application that integrates with [the Pokemon public API](https://pokeapi.co/) to retrieve Pokemon data.

This application uses the [Refit.HttpClientFactory](https://www.nuget.org/packages/refit.httpclientfactory) to test its implementation.

Another lib using is [QuestPDF](https://www.questpdf.com/) for generating PDF reports.

## Any generated reports:

![Pokemons](/Docs/Images/pokemon-data-explorer-reports.png)


NOTE: The project's objective was to study integration with the Pokémon API, extract some data, and generate some kind of output. Architecture was not given any attention, as it is not the focus of the study in question. However, in the future, refactoring could be done to separate everything correctly, using a clean architecture, for example, to keep the code better separated.
