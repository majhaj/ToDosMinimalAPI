namespace ToDos.MinimalAPI;

    public interface IToDoService
    {
    ToDo GetById(Guid id);
    List<ToDo> GetAll();
    void Create(ToDo toDo);
    void Update(ToDo toDo);
    void Delete(Guid id);

    }

