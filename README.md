# Automatic Idle Task Processor
 Aparato para automatizar a otimização de tarefas ociosas do sistema Windows.

<img src="./assets/Heya-p-Engine.png" align="left" width=200px>

##### **[Downloads & Release notes](https://github.com/mateusnssp/automatic-idle-task-processor/releases)**

No Windows é comum se deparar com travamentos no sistema, mesmo quando não acontece sobrecarga de recursos de memória e processamento. O que acontece na maioria dos casos, é uma ociosidade nas tarefas do sistema existente pela alta taxa de adiamentos de execução.
O mesmo não é comum em sistemas como Linux, pois é uma alternativa que a Microsoft adotou para situações diversas.
Essas tarefas ociosas podem ser controladas por uma API do sistema: `advapi32.dll, ProcessIdleTasks`, desenvolvida propriamente para forçar tarefas ociosas a serem executadas de imediato.

<br/>
O programa desenvolvido neste repositório nada mais faz, que executar em loop, a API com ajuda da ferramenta `rundll32.exe` disponibilizada pela Microsoft, localizada em `%windir%\system32`.

## Compilação

O aplicativo total é a pasta de saída (`bin`) criada com a construção: `dotnet build`, que reúne todas as dependência necessárias como os scripts objetivos:
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

Consulte [automatic-idle-processor.csproj](./automatic-idle-task-processor/automatic-idle-task-processor.csproj) para mais informações técnicas.

## Instalação 

Caso opte por instalar a aplicação, acesse a página [releases](https://github.com/mateusnssp/automatic-idle-task-processor/releases/tag/v0.0.3) e baixe o pacote de instalação mais recente (`x.x.x-Auto-ITP.msi`).

1. Você precisará de acesso do administrador para realizar a instalação.
2. Por favor, instale os arquivos para uma pasta que você tenha permissão de acesso total. Por exemplo, 'Program Files' não pode ser usada. É um problema que ainda não foi relatado.
3. Caso haja erros no momento da instalação, por gentileza reporte em [issues](https://github.com/mateusnssp/automatic-idle-task-processor/issues) detalhadamente.
4. Para verificar se o app está verdadeiramente funcionando, verifique se o arquivo `log.log` dentre os arquivos de instalação está sendo atualizada conforme o horário de seu sistema, caso contrário reporte em [issues](https://github.com/mateusnssp/automatic-idle-task-processor/issues).
