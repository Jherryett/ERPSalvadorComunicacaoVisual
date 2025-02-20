create table EnderecoFuncionario(
IdEnderecoFuncionario int identity (1,1) primary key)

alter table EnderecoFuncionario
add NomeRua varchar (200),
NomeBairro varchar (200),
NomeCidade varchar (200),
NomeEstado varchar (200),
Complemento1 varchar (200),
Complemento2 varchar (200),
DataCadastro DateTime,
IdFormatadaEnderecoFuncionario varchar(20);

create trigger IdFormatadaEnderecoFuncionario
on EnderecoFuncionario
after insert
as
begin
update EnderecoFuncionario
set IdFormatadaEnderecoFuncionario = format (EnderecoFuncionario.IdEnderecoFuncionario, 'END.FUN-00000')
from EnderecoFuncionario
inner join inserted on EnderecoFuncionario.IdEnderecoFuncionario = inserted.IdEnderecoFuncionario;
end;


drop trigger trg_Update_IdFormatada