<h1 align="center"><strong>Executando aplicações ASP.NET Core como Windows Service</strong></h1>

### ` 🔍 Sobre`

<p align="justify">As vezes precisamos realizar tarefas de longa duração em segundo plano na nossa aplicação, e, além disso, também é necessário que elas executem como um serviço do windows. Felizmente, ASP.NET Core possibilita esse tipo de abordagem de forma bem simples.</p>

### `🔎 Como utilizar?`
```
git clone https://github.com/devjamesbrandao/background-services-windows-service</p>

dotnet restore</p>

dotnet build</p>

dotnet publish -o /app 

sc create "Estudos-Service" binpath="caminho do executavel" (executar no cmd como ADM)

sc start "Estudos-Service" (executar no cmd como ADM)
```

### ` 📜 Notas`
#### Como criar um aplicativo BackGround Service com o dotnet CLI?
> dotnet new worker --name nome_do_projeto

#### Como iniciar serviço do windows criado no exemplo?
> sc create "Estudos-Service" (executar no cmd como administrador)

#### Como parar o serviço do windows criado no exemplo?
> sc stop "Estudos-Service" (executar no cmd como administrador)

#### Como deletar o serviço do windows criado no exemplo?
> sc delete "Estudos-Service" (executar no cmd como administrador)

### ` 🌐 Referências`

- <p> Running .NET Core Applications as a Windows Service: https://code-maze.com/aspnetcore-running-applications-as-windows-service/</p>





