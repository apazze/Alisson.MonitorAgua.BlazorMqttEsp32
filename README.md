# Projeto de TCC (2022/2) Monitoramento remoto do consumo de água

Site publicado em:

http://monitoragua.azurewebsites.net/

Rodar 1°
Alisson.MonitorAgua:

Broker Mqtt (Server) roda na porta 5011.
Recebe as msgs da ESP32 e grava no banco
Recebe as msgs do Alisson.MonitorAgua.Client para enviar à ESP32

Rodar 2° (https://github.com/apazze/ProjetoTCC/tree/main/MonitorAgua)
IDE Arduino

Controla a vazão através da ESP32, enviará todos os dias às 23:59:59 se houver fluxo
Conecta ao Broker e publica no tópico "monitorAgua/vazao" para enviar os dados
Assina o tópico "monitorAgua/advertencia" para receber as msgs de Alisson.MonitorAgua.Client para acionar a rotina de advertencia

Rodar 3°
Alisson.MonitorAgua.Client

Cliente Mqtt que se conecta ao Broker e faz verificação a cada 10s no BD dos valores de vazao recebidos
Se for maior que o ultimo valor configurado, irá publicar um "true" no tópico "monitorAgua/advertencia" somente uma vez no dia

Rodar 4°
Plotly.Examples

Site que gera o relatório dos valores enviados pela ESP32 na index. Na guia Regra configura o valor de limite e grava no banco


Integração à IDE:
https://USUARIO:TOKEN@URL.git

Exemplo:
https://apazze:TOKEN@github.com/apazze/JavaWiki.git


20221127

Limpar DB, excluir DB no SQL Server Object explorer e a pasta Migrations do MonitorAgua
Definir o monitorAgua como projeto de inicialização e conferir na checkbox do console do gerenciador de pacotes
Executar no console do gerenciador de pacotes
Add-Migration first 
Update-Database

QQ coisa recompilar solução

Criar hotspot movel e ver ip no cmd (configurar na esp)

No VS seleciona a checkbox com o projeto e iniciar sem depurar (play sem preenchimento)

1 MonitorAgua - Broker
2 Esp
3 Client
4 Web

Na web esta sendo exibido a media mensal e nao o total consumido no dia

Conta quantos registros que tem daquele mes, soma os registros de litros e divide pelo contador
