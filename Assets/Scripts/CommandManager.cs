using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommand
{
    void Execute();
    void Undo();
}
public class MoveCommand : ICommand
{
    private Transform objectToMove;
    private Vector3 displacement;
    public MoveCommand(Transform objectToMove, Vector3 displacement)
    {
        this.objectToMove = objectToMove;
        this.displacement = displacement;
    }
    public void Execute() { objectToMove.position += displacement;}
    public void Undo() { objectToMove.position -= displacement; }
}

public class CommandManager : MonoBehaviour
{
    // Stack 형태로 커맨드 관리
    private Stack<ICommand> commandHistory = new Stack<ICommand>();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        commandHistory.Push(command);
    }

    public void UndoLastCommand()
    {
        if (commandHistory.Count > 0)
        {
            ICommand lastCommand = commandHistory.Pop();
            lastCommand.Undo();
        }
    }
}
