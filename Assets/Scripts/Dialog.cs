using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Dialog : MonoBehaviour
{
    public GameObject panel;
    public Text TextDialog;
    public string[] message;
    public bool StartDialog = false;

    private void Start()
    {
        message[0] = "������:��, ���� ��� �� ��� �������?";
        message[1] = "����:(��������)";
        message[2] = "������: ���� ����������?";
        message[3] = "����: ���? �� ��� ������? ��� �� ������ � ������� ����?";
        message[4] = "������: ����� ����� ���������� ����� �� ������, ���-���� ��������� ����-�� ��������";
        message[5] = "������: � ������ ��� ����� ������� ���� � ������ ������";
        message[6] = "����: ����� �����, ��� �� ������ ������?";
        message[7] = "������: � ���� ��� ��� ������";
        message[8] = "����: ����...., ����� ���� ������";


        panel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            panel.SetActive(true);
            TextDialog.text = message[0];
            StartDialog = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        panel.SetActive(false);
        StartDialog = false;
    }
    private void Update()
    {
        if (StartDialog == true)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                TextDialog.text = message[1];
                
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                TextDialog.text = message[2];
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                TextDialog.text = message[3];
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                TextDialog.text = message[4];
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                TextDialog.text = message[5];
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                TextDialog.text = message[6];
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                TextDialog.text = message[7];
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                TextDialog.text = message[8];
            }
        }
    }
}
