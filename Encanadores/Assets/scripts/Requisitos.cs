using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Requisitos : MonoBehaviour {

	public Text detalhes;
	public Text orcamento;
	public Text prazo;

	void Start () {
		detalhes.text 	= Utils.getInstance().getDetalhes();
		orcamento.text 	= Utils.getInstance().getOrcamento();
		prazo.text 		= Utils.getInstance().getPrazo();
	}
}
