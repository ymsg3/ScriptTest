using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kadai : MonoBehaviour
{

    void Start()
    {
        Debug.Log("�� �ۑ�ł��B");

        // �v�f�̌���5�́Aint�^�̔z��array��錾���čD���Ȓl�ŏ�����
        int[] array = { 1, 4, 10, 40, 20 };

        Debug.Log("---���Ԃɕ\�����܂��B---");

        // for�����g���A�z��̊e�v�f�̒l�����Ԃɕ\��
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        Debug.Log("---�t���ɕ\�����܂��B---");

        // for�����g���A�z��̊e�v�f�̒l���t���ɕ\��
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

    }

}
