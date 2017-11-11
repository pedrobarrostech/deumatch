# Equipe 34 - Deu Match!

## Primeiro GIT Realizado em Outro Bucket, verificado por Luciano Santana e trata-se do mesmo arquivo COmmitado no prazo#

Aplicação desenvolvida para facilitar a busca de profissionais avaliando tanto o perfil comportamental quanto o técnico.

### Como executar o WebUI ###

```js
cd deu-match-webui
npm install
npm start
```

### Como executar a WebAPI ###
```sh
docker run --name mysql -e MYSQL_ROOT_PASSWORD=root -p 3306:3306 --volume=/Users/pedrobarros/mysql:/var/lib/mysql -d mysql

cd deu-match-rest
dotnet restore
dotnet build

cd src/DotNetCoreAppExample.Infra.Data
dotnet ef database update

cd ../DotNetCoreAppExample.Infra.CrossCutting.Identity
dotnet ef database update

cd ../DotNetCoreAppExample.Services.Api
dotnet run 
```

