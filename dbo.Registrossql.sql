CREATE TABLE Registros
(
	Operacao varchar(MAX),
    Cliente varchar(MAX),
    RDVI varchar(MAX),
    DI varchar(MAX),
    StatusProcesso varchar(MAX),
    DataHoraProgramacao varchar(MAX),
    DataHoraLiberacaoDoc varchar(MAX),
    DataProgramacaoEntrega varchar(MAX),
    Especie varchar(MAX),
    PesoBruto varchar(MAX),
    Volumes varchar(MAX),
    LocalCarregamento varchar(MAX),
    LocalDescarga varchar(MAX),
    PlacaVeiculo varchar(MAX),
    Motorista varchar(MAX),
    Situacao varchar(MAX),
    Status varchar(MAX),
    DataHoraProgrLocalColeta varchar(MAX),
    DataHoraChegadaLocalColeta varchar(MAX),
    DataHoraSaidaLocalColeta varchar(MAX),
    DataHoraProgrLocalDescarga varchar(MAX),
    DataHoraChegadaLocalDescarga varchar(MAX),
    DataHoraSaidaLocalDescarga varchar(MAX), 
    [Id] UNIQUEIDENTIFIER NULL
)

