﻿namespace Ordering.Domain.Abstractions;

public abstract class Entit<T> : IEntity<T>
{
    public T Id { get; set; }
    public DateTime? CreateAt { get; set; }
    public string? CreateBy { get; set; }
    public DateTime? LastModified {  get; set; }
    public string? LastModifiedBy { get; set; }
}
