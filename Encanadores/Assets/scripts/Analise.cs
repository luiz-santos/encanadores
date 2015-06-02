using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Analise : MonoBehaviour {

	public Text resumo;
	public Text resumo2;
	public Text recompensas;

	void Start () {
		resumo.text = "<b>Detalhes</b>\n" + Utils.getInstance ().getDetalhes ();
		resumo2.text = "<b>Orçamento</b>\n" + Utils.getInstance ().getOrcamento() +
			"\n\n<b>Prazo</b>\n" + Utils.getInstance ().getPrazo();
	}
}
