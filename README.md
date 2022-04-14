Rodar 1°
Alisson.MonitorAgua:

Broker Mqtt (Server) roda na porta 5011.
Recebe as msgs dos sensores (publish) e grava no banco;

Rodar 2° (https://github.com/apazze/ProjetoTCC/tree/main/MonitorAgua)
IDE Arduino

Controla a vazão através da ESP32, enviará dados de vazão a cada 10min se houver fluxo. 
Conecta ao Broker e publica no tópico "monitorAgua/vazao" para enviar os dados.
Assina o tópico "monitorAgua/advertencia" para receber as msgs para acionar ou não a rotina de advertencia. Se for true,
vai acionar o relé somente uma vez no dia que passou do limite configurado.

Rodar 3°
Alisson.MonitorAgua.Client

Cliente Mqtt que se conecta ao Broker e faz verificação a cada 10s no BD dos valores de vazao recebidos.
Se for maior que o ultimo valor configurado, irá publicar um "true" no tópico "monitorAgua/advertencia" somente uma vez no dia.

Rodar 4°
Plotly.Examples

Site que gera o relatório dos valores enviados pela ESP32 na index. Na guia Regra configura o valor de limite e grava no banco.
