﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace SF
{
    #region Контексты
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    public partial class TestEntities1 : ObjectContext
    {
        #region Конструкторы
    
        /// <summary>
        /// Инициализирует новый объект TestEntities1, используя строку соединения из раздела "TestEntities1" файла конфигурации приложения.
        /// </summary>
        public TestEntities1() : base("name=TestEntities1", "TestEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Инициализация нового объекта TestEntities1.
        /// </summary>
        public TestEntities1(string connectionString) : base(connectionString, "TestEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Инициализация нового объекта TestEntities1.
        /// </summary>
        public TestEntities1(EntityConnection connection) : base(connection, "TestEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Разделяемые методы
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Свойства ObjectSet
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        public ObjectSet<CharacterTable> Character
        {
            get
            {
                if ((_Character == null))
                {
                    _Character = base.CreateObjectSet<CharacterTable>("Character");
                }
                return _Character;
            }
        }
        private ObjectSet<CharacterTable> _Character;

        #endregion

        #region Методы AddTo
    
        /// <summary>
        /// Устаревший метод для добавления новых объектов в набор EntitySet Character. Взамен можно использовать метод .Add связанного свойства ObjectSet&lt;T&gt;.
        /// </summary>
        public void AddToCharacter(CharacterTable characterTable)
        {
            base.AddObject("Character", characterTable);
        }

        #endregion

    }

    #endregion

    #region Сущности
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TestModel", Name="CharacterTable")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CharacterTable : EntityObject
    {
        #region Фабричный метод
    
        /// <summary>
        /// Создание нового объекта CharacterTable.
        /// </summary>
        /// <param name="id">Исходное значение свойства id.</param>
        public static CharacterTable CreateCharacterTable(global::System.Int32 id)
        {
            CharacterTable characterTable = new CharacterTable();
            characterTable.id = id;
            return characterTable;
        }

        #endregion

        #region Свойства-примитивы
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Str
        {
            get
            {
                return _Str;
            }
            set
            {
                OnStrChanging(value);
                ReportPropertyChanging("Str");
                _Str = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Str");
                OnStrChanged();
            }
        }
        private Nullable<global::System.Int32> _Str;
        partial void OnStrChanging(Nullable<global::System.Int32> value);
        partial void OnStrChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Endur
        {
            get
            {
                return _Endur;
            }
            set
            {
                OnEndurChanging(value);
                ReportPropertyChanging("Endur");
                _Endur = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Endur");
                OnEndurChanged();
            }
        }
        private Nullable<global::System.Int32> _Endur;
        partial void OnEndurChanging(Nullable<global::System.Int32> value);
        partial void OnEndurChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Const
        {
            get
            {
                return _Const;
            }
            set
            {
                OnConstChanging(value);
                ReportPropertyChanging("Const");
                _Const = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Const");
                OnConstChanged();
            }
        }
        private Nullable<global::System.Int32> _Const;
        partial void OnConstChanging(Nullable<global::System.Int32> value);
        partial void OnConstChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Dex
        {
            get
            {
                return _Dex;
            }
            set
            {
                OnDexChanging(value);
                ReportPropertyChanging("Dex");
                _Dex = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Dex");
                OnDexChanged();
            }
        }
        private Nullable<global::System.Int32> _Dex;
        partial void OnDexChanging(Nullable<global::System.Int32> value);
        partial void OnDexChanged();

        #endregion

    
    }

    #endregion

    
}