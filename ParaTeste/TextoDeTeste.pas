program Exemplo;

uses
  SysUtils;

const
  PI = 3.14159;
  MAX = 100;

var
  idade: Integer;
  altura, 2CasasDecimais: Double;
  nome, _sobrenome: string;
  x, y: Integer;

procedure MostrarMensagem(msg: string);
begin
  writeln(msg);
end;

function Dobro(x: Integer): Integer;
begin
  Result := 2 * x;
end;

// Este é um comentário 

begin
  idade := 25;
  altura := 1.75;
  nome := 'João';
  x := 10;
  y := 20;

  MostrarMensagem('Olá, Mundo!');

  writeln('A idade é ', idade);
  writeln('O dobro de x é ', Dobro(x));
end.
