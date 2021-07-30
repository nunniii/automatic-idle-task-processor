[![Open Source Love](https://badges.frapsoft.com/os/v1/open-source.svg?v=103)](https://github.com/ellerbrock/open-source-badges/) [![MIT Licence](https://badges.frapsoft.com/os/mit/mit.png?v=103)](https://opensource.org/licenses/mit-license.php)

# Automatic Idle Task Processor
 Aparato para automatizar a otimização de tarefas ociosas do sistema Windows mantendo os processos do sistema otimizados.
 Este repositório abriga um dos motores de [Heya-p](https://github.com/Heya-p).

<img src="./assets/Heya-p-Engine.png" align="left" width=200px>

##### **[Downloads & Release notes](https://github.com/mateusnssp/automatic-idle-task-processor/releases)**

No Windows é comum se deparar com travamentos no sistema, mesmo quando não acontece sobrecarga de recursos de memória e processamento. O que acontece na maioria dos casos, é uma ociosidade nas tarefas do sistema existente pela alta taxa de adiamentos de execução.
O mesmo não é comum em sistemas como Linux, pois é uma alternativa que a Microsoft adotou para situações diversas.
Essas tarefas ociosas podem ser controladas por uma API do sistema: `advapi32.dll, ProcessIdleTasks`, desenvolvida propriamente para forçar tarefas ociosas a serem executadas de imediato.

<br/>

O programa desenvolvido neste repositório nada mais faz, que executar em loop, a API com ajuda da ferramenta `rundll32.exe` disponibilizada pela Microsoft, localizada em `%windir%\system32`.

## Obtendo

A compilação é a maneira mais recomendada para uso, como segue os passos a seguir. Mas caso prefira, siga o guia para uso do instalador.
Você pode utilizar o compilador C# da microsoft que já vem instalado no Windows conforma os passos a seguir, mas recomendo fortemente que utilize o .NET SDK conforme também listado neste guia.

### Compilação

#### Compilador do .NET SDK (Recomendado)

1. Clone ou faça o download deste repositório.

1. Instale a versão recomendada pela microsoft do .NET em: [https://aka.ms/dotnet-download](https://aka.ms/dotnet-download)

2. Na pasta do projeto (`automatic-idle-task-processor\automatic-idle-task-processor`), execute: 

```
dotnet build
```

O aplicativo total é a pasta de saída (`bin`) criada com a construção: `dotnet build`, que reúne todas as dependência necessárias como os scripts, conforme você pode ver detalhadamente em [automatic-idle-processor.csproj](./automatic-idle-task-processor/automatic-idle-task-processor.csproj):
```
<ItemGroup>
    <None Include="log.log">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
    <None Include="rundll32.bat">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
</ItemGroup>
<ItemGroup>
    <Content Include="hide.vbs">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Content>
</ItemGroup>
```

#### Compilador C# (`csc.exe`)

1. Clone ou faça o download deste repositório.

1. Você pode executar a instalação utilizando o compilador dotnet: procure onde está o arquivo `csc.exe` pelo cmd com:

```
cd C:\Windows\Microsoft.NET
dir /s csc.exe
```

Você terá uma saída como essa:

```
Pasta de C:\Windows\Microsoft.NET\Framework\v4.0.30319

07/12/2019  06:10         2.141.552 csc.exe
      1 arquivo(s)      2.141.552 bytes

Pasta de C:\Windows\Microsoft.NET\Framework64\v4.0.30319

07/12/2019  06:10         2.759.232 csc.exe
      1 arquivo(s)      2.759.232 bytes


    Total de Arquivos na Lista:
      2 arquivo(s)      4.900.784 bytes
      0 pasta(s)   715.428.761.600 bytes disponíveis

```

2. Opte por qualquer dos caminhos retornados no passo anterior e execute na pasta `automatic-idle-task-processor\`:

```
  {diretório-retornado}\csc.exe Program.cs
```

3. Pronto, apenas certifique-se de manter os arquivos `log.log`, `hide.vbs`, `rundll32.bat` e o executável gerado no mesmo diretório para que funcionem.
É normal que `log.log` seja atualizado constantemente.


### Instalador 

Caso opte por instalar a aplicação sem a compilar, acesse a página [releases](https://github.com/mateusnssp/automatic-idle-task-processor/releases/tag/v0.0.3) e baixe o pacote de instalação mais recente (`x.x.x-Auto-ITP.msi`).

1. Você precisará de acesso do administrador para realizar a instalação.
2. Por favor, instale os arquivos para uma pasta que você tenha permissão de acesso total. Por exemplo, 'Program Files' não pode ser usada. É um problema que ainda não foi relatado.
3. Caso haja erros no momento da instalação, por gentileza reporte em [issues](https://github.com/mateusnssp/automatic-idle-task-processor/issues) detalhadamente.
4. Para verificar se o app está verdadeiramente funcionando, verifique se o arquivo `log.log` dentre os arquivos de instalação está sendo atualizada conforme o horário de seu sistema, caso contrário reporte em [issues](https://github.com/mateusnssp/automatic-idle-task-processor/issues).







