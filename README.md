# 五子棋遊戲 (Five in a Row)

一款使用 C# WinForms 開發的五子棋遊戲，支援單人（對戰 AI）與雙人本地對戰兩種模式。
<img width="600" height="650" alt="螢幕擷取畫面 2026-05-27 161614" src="https://github.com/user-attachments/assets/2a98dc3b-c8c0-4a15-bed6-61f3e91745ee" />


---

## 功能特色

- **單人模式**：玩家（黑子）vs 電腦 AI（白子）
- **雙人模式**：玩家 1（黑子）vs 玩家 2（白子）輪流下棋
- AI 具備進攻與防守評分邏輯
- 支援勝負判斷（水平、垂直、斜向四方向）
- 可重新開始遊戲
- **遊戲音效** : 1.在下棋時會有下棋音效 2.在遊戲結束時會有勝利音效

[single_player_losing.wav](https://github.com/user-attachments/files/28100080/single_player_losing.wav) *(這個是AI獲勝時的音效)*


---

## 遊戲模式

### 單人模式
- 玩家執黑棋，電腦 AI 執白棋
- 玩家先手，AI 自動計算最佳落點回應

### 雙人模式
- 玩家 1 執黑棋，玩家 2 執白棋
- 兩人輪流在同一台電腦上落子

---

## 開發環境

| 項目 | 內容 |
|------|------|
| 語言 | C# |
| 框架 | .NET WinForms |
| IDE | Visual Studio |

---

## 如何執行

1. 使用 Visual Studio 開啟 `five_in_a_row.sln`
2. 確認 `Properties/Resources` 中已包含以下圖片資源：
   - `checkerboard`（棋盤背景）
   - `black`（黑棋）
   - `white`（白棋）
3. 按下 `F5` 執行專案
4. 選擇遊戲模式後即直接開始

---

## 操作方式

<table>
  <tr>
    <td>

| 動作 | 說明 |
|------|------|
| 滑鼠點擊棋盤 | 落子 |
| 開始遊戲按鈕 | 選擇模式並啟動遊戲 |
| 再來一局按鈕 | 重置棋盤，重新開始 |

  </td>
     <td>
        <img width="300" height="300" alt="Adobe Express - 影片專案 1" src="https://github.com/user-attachments/assets/fdaeb264-51e5-40b2-9600-8b5f344d2030" />
    </td>
     <td>
   <img width="300" height="300" alt="image" src="https://github.com/user-attachments/assets/7efd6003-fac6-4e18-a8ce-2795865be447" />
     </td>
  </tr>
</table>

---

## AI 邏輯說明（單人模式）

AI 採用**評分系統**，對棋盤上每個空格計算分數，選擇分數最高的位置落子。

評分規則如下：

| 情況 | 分數 |
|------|------|
| AI 4子連線（快贏） | 10000 |
| 玩家 4子連線（必須擋） | 9000 |
| AI 3子連線 | 1000 |
| 玩家 3子連線 | 800 |
| AI 2子連線 | 100 |
| 玩家 2子連線 | 50 |

每次落子同時計算**進攻分**與**防守分**，取總分最高的位置。


<img width=30% height="222" alt="image" src="https://github.com/user-attachments/assets/40819c87-d9f3-41dd-88eb-8b100ff3bfab" />
<img width=30% height="237" alt="image" src="https://github.com/user-attachments/assets/d36d7800-0ed2-416e-9ecf-6162d54b165e" />
<img width=30% height="315" alt="image" src="https://github.com/user-attachments/assets/f9c9bfa7-852b-4d1d-b586-18a23b65c5cc" />
