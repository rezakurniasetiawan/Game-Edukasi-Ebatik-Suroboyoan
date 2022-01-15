using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  

public class game1 : MonoBehaviour
{
    public string[] soal, jawaban;


    public Text text_soal, text_skor;

    public InputField input_jawaban;

    public GameObject feed_benar, feed_salah, selesai, banksoal ,lanjut ,lanjutkanbermain ;

    int urutan_soal = -1,skor = 0;

    private void Start()
    {
        tampil_soal();
    }

    void tampil_soal()
    {
        urutan_soal++;
        text_soal.text = soal[urutan_soal];
    }

    public void jawab()
    {
        if (urutan_soal < soal.Length -1)
        {
            if (input_jawaban.text == jawaban[urutan_soal])
            {
                feed_benar.SetActive(false);
                feed_benar.SetActive(true);
                feed_salah.SetActive(false);
                skor += 20;
            }
            else
            {
                feed_benar.SetActive(false);
                feed_salah.SetActive(false);
                feed_salah.SetActive(true);
            }
            input_jawaban.text = "";
            tampil_soal();
        }
        else
        {
            if (input_jawaban.text == jawaban[urutan_soal])
            {
                skor += 20;
            }
            feed_benar.SetActive(false);
            feed_salah.SetActive(false);
            selesai.SetActive(true);
            banksoal.SetActive(false);
        }

    }

    void Update()
    {
        text_skor.text = skor.ToString();

        if (skor >= 80)
        {
            lanjut.SetActive(true);
        }
        else
        {
            lanjut.SetActive(false);
        }

    }
    public void hapusjwb1()
    {
        input_jawaban.text = "";
    }

    public void lanjutkemain()
    {
        lanjutkanbermain.SetActive(false);
    }
    public void backgame()
    {
        SceneManager.LoadScene("Game");
    }

}
