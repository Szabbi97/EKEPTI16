-module(listabejaras).
-export([listabejar/1]).

listabejar([Eleje|Vege])->
	io:format("~w~n",[Eleje]),
	listabejar(Vege);
listabejar([])->
	ok.