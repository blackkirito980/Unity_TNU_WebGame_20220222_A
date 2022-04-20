using System.Collections;
using System.Collections.Generic;
using UnityEngine; // 引用 Unity Engine 命名空間

namespace KID
{ 
    // 類別 (腳本) 名稱必須與左上角檔名完全相同，包含大小寫，檔名不能有空格或特殊字元
    /// <summary>
    /// 上下類型腳色控制器
    /// 控制移動、動畫更新
    /// </summary>
    public class TopDownControllers : MonoBehaviour
    {
        #region 資料:保存系統需要的資料。例如移動速度、動畫參數名稱或元件等資料
        // 欄位語法: 修飾詞 資料類型 欄位名稱 (指定 預設值);
        // [] 屬性 Attritude
        // SerializeField 序列畫欄位 - 欄位可視化 (出現在屬性面板 Inspector)
        // Header 標題
        // Range 範圍 : ※ 景適用於數值類型資料，int·float
        [SerializeField, Header("移動速度"), Range(0, 500)]
        private float speed = 1.5f;
        private string parameterRun = "開始跑步";
        private string parameterDead = "開始死亡";
        private Animator ani;
        private Rigidbody2D rig;
        private float h;
        private float v;
        #endregion
        
        
        //#region 方法:較複雜的行為，例如移動功能、更新動畫
        //#endregion
        
        #region 事件:程式的入口 (Unity)
        // 喚醒事件 :撥放遊戲時執行一次，處理初始值
        private void Awake()
        {
            // GetComponent<泛型>()。 泛型:指任何類型
            // 欄位 指定 取得元件<元件名稱>() - 取得指定元件存放於欄位
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
            
            GetInput();
            Move();
            Rotate();
        }
        #endregion
        #region 方法:較複雜的行為，例如移動功能、更新動畫



        //取得輸入:水平與垂直
        //</summary>
        private void GetInput()
        {
            //使用靜態資料 static
            //語法:類別名稱,靜態方法名稱 (對應引數)
            //Horizontal 水平軸向
            
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
        }
        private void Move()
        {
            rig.velocity = new Vector2(h, v).normalized * speed * Time.deltaTime;
            ani.SetBool(parameterRun, h != 0 || v !=0);
        }
        private void Rotate()
        {
            transform.eulerAngles = new Vector3(0, h >= 0 ? 0 : 180, 0);
        }
        #endregion
    }

}
