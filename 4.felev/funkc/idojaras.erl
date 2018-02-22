-module(idojaras).
-export([adatok/0,listabejar/1]).

adatok()->
[{bp,10},{eger,12},{pecs,8},{nyiregyhaza,9}].

listabejar([{Varos,Fok}|Vege])->
	io:format("Varos neve: ~w, homerseklet: ~w~n",[Varos,Fok]),
	listabejar(Vege);
listabejar([])->
	ok.

