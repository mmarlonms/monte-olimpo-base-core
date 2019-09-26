[![Build Status](https://dev.azure.com/MMarlonMs/MonteOlimpo/_apis/build/status/mmarlonms.monte-olimpo-base-core)](https://dev.azure.com/MMarlonMs/MonteOlimpo/_build/latest?definitionId=1)

![Logo](https://github.com/mmarlonms/monte-olimpo-base-core/blob/master/docs/monte-olimpo-base-core.png)


# Monte Olimpo - Base Core 
Base de negócio para aplicaçoes MonteOlimpo.

* __MonteOlimpo.Base.Core.Domain__
	* Apresenta o contexto base do Domínio das aplicações.
	* Interfaces base de Service, Repository, Model, Specification e UnitOfWork
*	__MonteOlimpo.Base.Core.Service__
	*	Apresenta a BaseService com as implementações básicas de um serviço ( Create, SelectAll, GetById, Update, Delete) 
	*	Referências:
		*	 [MonteOlimpo.Base.Core.Domain/](https://www.nuget.org/packages/MonteOlimpo.Base.Core.Domain/)
*	__MonteOlimpo.Base.Core.Data__
	*	Apresenta a Implementação do UnitOfWork que é utilizado no BaseRepository, este com as implementações básicas de um repositório (add, delete, list, getById, GetBySpecification, ListBySpecification)
	*	Referências:
		* [MonteOlimpo.Base.Core.Domain/](https://www.nuget.org/packages/MonteOlimpo.Base.Core.Domain/)
	* Referências Externas:
		*  [Awesome Repository Pattern](https://blog.kylegalbraith.com/2018/03/06/getting-familiar-with-the-awesome-repository-pattern/)
		* [# Unit of work - O padrão de unidade de trabalho (.NET)](https://www.devmedia.com.br/unit-of-work-o-padrao-de-unidade-de-trabalho-net/25811)
* __MonteOlimpo.Base.Core.Specification__
	* Apresenta a implementação base de uma Specification.
		* Referências:
			* [MonteOlimpo.Base.Core.Domain/](https://www.nuget.org/packages/MonteOlimpo.Base.Core.Domain/)
		* Referências Externas:
			* [Spectfication Pattern Implementation/](https://enterprisecraftsmanship.com/posts/specification-pattern-c-implementation/)
			* [Specification Pattern](https://en.wikipedia.org/wiki/Specification_pattern)
*  __MonteOlimpo.Base.Core.DataAnnotations__
	* Apresenta conjuntos de annotations  genéricas que trablham junto com o tratamento de exceções em [monte-olimpo-base](https://github.com/mmarlonms/monte-olimpo-base).
		* Referências Externas : 
			* [otc-annotations](https://github.com/OleConsignado/otc-annotations)
			* [System.ComponentModel.Annotations](https://github.com/dotnet/corefx/tree/v1.1.8/src/System.ComponentModel.Annotations)
			* [# Validação de modelo no ASP.NET Core MVC](https://docs.microsoft.com/pt-br/aspnet/core/mvc/models/validation?view=aspnetcore-2.2)
* __MonteOlimpo.Base.Core.Validations__
	* Apresenta a classe __ValidationHelper__ que valida um model com base nas annotations (MonteOlimpo.Base.Core.DataAnnotations)
	* Referências: 
		* [MonteOlimpo.Base.Core.DataAnnotations/](https://www.nuget.org/packages/MonteOlimpo.Base.Core.DataAnnotations/)
		* [MonteOlimpo.Base.CoreException/](https://www.nuget.org/packages/MonteOlimpo.Base.CoreException/)
	* Referências Externas:
		* [otc-validations](https://github.com/OleConsignado/otc-validations)
* __MonteOlimpo.Base.Core.CrossCutting__
	* Apresenta a classe __RegisterMonteOlimpoBaseCore__ no qual tem como função configurar o contexto, o tipo banco e o Unit Of Work.
	* Referências: 
		* [MonteOlimpo.Base.Extensions/](https://www.nuget.org/packages/MonteOlimpo.Base.Extensions/)
		* [MonteOlimpo.Base.Core.Domain/](https://www.nuget.org/packages/MonteOlimpo.Base.Core.Domain/)
		* [MonteOlimpo.Base.Core.Data/](https://www.nuget.org/packages/MonteOlimpo.Base.Core.Data/)
* __MonteOlimpo.Base.Core.Tests__
	* Apresenta a solução para testes integrados através do __TestsFixture__, este adiciona um contexto em memória para os testes, no qual se torna possível utilizar o IoC desde a camada de serviço até a camada de repositório, ganhando performance maior assertividade nos testes, além de, __não precisar de utilziar mocs ou fakes para o banco de dados ou repositório__. Obs.: Recomendado para testes de negocio e integração por se tratar de um baco de dados em memoria. 
	* Referências: 
		* [MonteOlimpo.Base.Core.Data/](https://www.nuget.org/packages/MonteOlimpo.Base.Core.Data/)	
		*  [MonteOlimpo.Base.Extensions/](https://www.nuget.org/packages/MonteOlimpo.Base.Extensions/)

## Nuget details
|Packages|Version & Downloads|
|---------------------------|:---:|
|*MonteOlimpo.Base.Core.Domain*|[![NuGet Version and Downloads count](https://buildstats.info/nuget/MonteOlimpo.Base.Core.Domain)](https://www.nuget.org/packages/MonteOlimpo.Base.Core.Domain)|
|*MonteOlimpo.Base.Core.Specification*|[![NuGet Version and Downloads count](https://buildstats.info/nuget/MonteOlimpo.Base.Core.Specification)](https://www.nuget.org/packages/MonteOlimpo.Base.Core.Specification)|
|*MonteOlimpo.Base.Core.Data*|[![NuGet Version and Downloads count](https://buildstats.info/nuget/MonteOlimpo.Base.Core.Data)](https://www.nuget.org/packages/MonteOlimpo.Base.Core.Data)|
|*MonteOlimpo.Base.Core.DataAnnotations*|[![NuGet Version and Downloads count](https://buildstats.info/nuget/MonteOlimpo.Base.Core.DataAnnotations)](https://www.nuget.org/packages/MonteOlimpo.Base.Core.DataAnnotations)|
|*MonteOlimpo.Base.Core.Service*|[![NuGet Version and Downloads count](https://buildstats.info/nuget/MonteOlimpo.Base.Core.Service)](https://www.nuget.org/packages/MonteOlimpo.Base.Core.Service)|
|*MonteOlimpo.Base.Core.Tests*|[![NuGet Version and Downloads count](https://buildstats.info/nuget/MonteOlimpo.Base.Core.Tests)](https://www.nuget.org/packages/MonteOlimpo.Base.Core.Tests)|
|*MonteOlimpo.Base.Core.Validations*|[![NuGet Version and Downloads count](https://buildstats.info/nuget/MonteOlimpo.Base.Core.Validations)](https://www.nuget.org/packages/MonteOlimpo.Base.Core.Validations)|
|*MonteOlimpo.Base.Core.CrossCutting*|[![NuGet Version and Downloads count](https://buildstats.info/nuget/MonteOlimpo.Base.Core.CrossCutting)](https://www.nuget.org/packages/MonteOlimpo.Base.Core.CrossCutting)|



## ![SonarCloud](https://sonarcloud.io/images/project_badges/sonarcloud-white.svg)
[![SonarCloud](https://sonarcloud.io/api/project_badges/measure?project=monte-olimpo-base-core&metric=ncloc)](https://sonarcloud.io/dashboard?id=monte-olimpo-base-core)
[![SonarCloud](https://sonarcloud.io/api/project_badges/measure?project=monte-olimpo-base-core&metric=duplicated_lines_density)](https://sonarcloud.io/dashboard?id=monte-olimpo-base-core)
[![SonarCloud](https://sonarcloud.io/api/project_badges/measure?project=monte-olimpo-base-core&metric=bugs)](https://sonarcloud.io/dashboard?id=monte-olimpo-base-core)
[![SonarCloud](https://sonarcloud.io/api/project_badges/measure?project=monte-olimpo-base-core&metric=vulnerabilities)](https://sonarcloud.io/dashboard?id=monte-olimpo-base-core)
[![SonarCloud](https://sonarcloud.io/api/project_badges/measure?project=monte-olimpo-base-core&metric=code_smells)](https://sonarcloud.io/dashboard?id=monte-olimpo-base-core)




