﻿namespace Rowerowowo.Repository;

public interface IEntity<T>
{
    public T Id { get; set; }
}
