using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HattenKadai : MonoBehaviour
{

    // Lesson4�ō쐬�����v���W�F�N�gScriptTest�ɒǋL���܂��傤

    // Boss�N���X�ɂ��ĉ��L�̏����𖞂����Ă�������

    // Lesson4�ō쐬����Boss�N���X�����Ƃɍ쐬���Ă�������
    // int�^�̕ϐ�mp��錾���A53�ŏ��������Ă�������
    // mp������Ė��@�U��������Magic�֐�������Ă�������
    // Magic�֐�����mp��5�ȏ�̏ꍇ��5���炵�A�R���\�[���� ���@�U���������B�c��MP�́Z�Z�B �ƕ\�����Ă�������
    // mp������Ȃ��ꍇ�AMP������Ȃ����߁A���@���g���Ȃ��B �ƕ\�����Ă�������

    public class Boss
    {
        private int hp = 100; // �̗�
        private int power = 25; // �U����
        private int mp = 53; // MP

        // �U���p�̊֐�
        public void Attack()
        {
            Debug.Log(this.power + "�̃_���[�W��^����");
        }

        // �h��p�̊֐�
        public void Defence(int damage)
        {
            Debug.Log(damage + "�̃_���[�W���󂯂�");
            // �c��hp�����炷
            this.hp -= damage;
        }

        // ���@�U���p�̊֐�
        public void Magic()
        {
            int usage = 5; // ��񕪂̏����

            if (usage <= this.mp)
            {
                // �c��mp�������ꍇ�Amp�����炵�āA���b�Z�[�W��\��
                this.mp -= usage;
                Debug.Log("���@�U���������B�c��MP��" + this.mp + "�B");
            }
            else
            {
                // �c��mp������Ȃ��ꍇ�A���b�Z�[�W��\��
                Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
            }
        }

    }

    // Start�֐��ŉ��L�̏����𖞂����Ă�������

    // Magic�֐����Ăяo���āA���@���g���Ă�������
    // Magic�֐���10��g������ɁA�����Magic�֐����Ăяo���ƁA
    // mp������Ȃ����b�Z�[�W��\�����邱�Ƃ��m�F���Ă�������

    void Start()
    {
        Debug.Log("�� ���W�ۑ�ł��B");

        Boss boss = new Boss();

        Debug.Log("---10��Ăяo���܂��B---");

        // Magic��10��Ăяo��
        for (int i = 0; i < 10; i++)
        {
            boss.Magic();
        }

        Debug.Log("---����ɌĂяo���܂��B---");

        // ����ɌĂяo��
        boss.Magic();

    }

}
