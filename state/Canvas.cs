// Context
public class Canvas 
{
    Tool currentTool;
    
    public void MouseDown(){
        currentTool.MouseDown();
    }

    public void MouseUp(){
        currentTool.MouseUp();
    }

    public void SetCurrentTool(Tool currentTool){
        this.currentTool = currentTool;
    }
}