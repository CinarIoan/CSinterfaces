namespace csinterfaces
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}