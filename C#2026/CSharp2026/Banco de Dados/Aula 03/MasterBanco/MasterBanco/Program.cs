using MasterBanco.Classes.Entidade;


/*
Banco conta1 = new Banco("Kelwin", 1005, 1674.69m);

Banco.CadastrarContas(conta1);
*/
Banco.LerContas();

Banco.ModificarConta(2, "Senai", 5000, 61.69m);

Banco.LerContas();

Banco.DeletarConta(4);

Banco.LerContas();


