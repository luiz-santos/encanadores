using UnityEngine;
using System.Collections;

public class Utils {

	static Utils instance;

	int projectCount;
	string detalhes;
	string prazo;
	string orcamento;

	// Initialize with default values
	public Utils() {
		detalhes 	= "3 pontos de entrada/saida\n" +
			"1 juncao de 4 saidas\n" +
			"2 juncoes de 3 saidas\n\n" +
			"Minimo de 3 conectores\n" +
			"Maximo de 6 conectores";
		prazo 		= "01:27";
		orcamento 	= "$12,80";
	}

	public string getDetalhes() {
		return detalhes;
	}

	public string getPrazo() {
		return prazo;
	}

	public string getOrcamento() {
		return orcamento;
	}

	public static Utils getInstance() {
		if (instance == null)
			instance = new Utils ();
		return instance;
	}
}
