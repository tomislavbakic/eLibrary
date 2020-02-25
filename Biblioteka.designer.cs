﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biblioteka
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="elibrary")]
	public partial class BibliotekaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertautor(autor instance);
    partial void Updateautor(autor instance);
    partial void Deleteautor(autor instance);
    partial void Insertknjiga(knjiga instance);
    partial void Updateknjiga(knjiga instance);
    partial void Deleteknjiga(knjiga instance);
    partial void Insertkorisnik(korisnik instance);
    partial void Updatekorisnik(korisnik instance);
    partial void Deletekorisnik(korisnik instance);
    partial void Insertzaduzenje(zaduzenje instance);
    partial void Updatezaduzenje(zaduzenje instance);
    partial void Deletezaduzenje(zaduzenje instance);
    #endregion
		
		public BibliotekaDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["elibraryConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BibliotekaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BibliotekaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BibliotekaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BibliotekaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<autor> autors
		{
			get
			{
				return this.GetTable<autor>();
			}
		}
		
		public System.Data.Linq.Table<knjiga> knjigas
		{
			get
			{
				return this.GetTable<knjiga>();
			}
		}
		
		public System.Data.Linq.Table<korisnik> korisniks
		{
			get
			{
				return this.GetTable<korisnik>();
			}
		}
		
		public System.Data.Linq.Table<zaduzenje> zaduzenjes
		{
			get
			{
				return this.GetTable<zaduzenje>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.autor")]
	public partial class autor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _ime;
		
		private string _prezime;
		
		private EntitySet<knjiga> _knjigas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnimeChanging(string value);
    partial void OnimeChanged();
    partial void OnprezimeChanging(string value);
    partial void OnprezimeChanged();
    #endregion
		
		public autor()
		{
			this._knjigas = new EntitySet<knjiga>(new Action<knjiga>(this.attach_knjigas), new Action<knjiga>(this.detach_knjigas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ime", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ime
		{
			get
			{
				return this._ime;
			}
			set
			{
				if ((this._ime != value))
				{
					this.OnimeChanging(value);
					this.SendPropertyChanging();
					this._ime = value;
					this.SendPropertyChanged("ime");
					this.OnimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prezime", DbType="VarChar(50)")]
		public string prezime
		{
			get
			{
				return this._prezime;
			}
			set
			{
				if ((this._prezime != value))
				{
					this.OnprezimeChanging(value);
					this.SendPropertyChanging();
					this._prezime = value;
					this.SendPropertyChanged("prezime");
					this.OnprezimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="autor_knjiga", Storage="_knjigas", ThisKey="id", OtherKey="idAutora")]
		public EntitySet<knjiga> knjigas
		{
			get
			{
				return this._knjigas;
			}
			set
			{
				this._knjigas.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_knjigas(knjiga entity)
		{
			this.SendPropertyChanging();
			entity.autor = this;
		}
		
		private void detach_knjigas(knjiga entity)
		{
			this.SendPropertyChanging();
			entity.autor = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.knjiga")]
	public partial class knjiga : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _naslov;
		
		private int _idAutora;
		
		private int _godinaIzdanja;
		
		private int _kolicina;
		
		private EntitySet<zaduzenje> _zaduzenjes;
		
		private EntityRef<autor> _autor;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnaslovChanging(string value);
    partial void OnnaslovChanged();
    partial void OnidAutoraChanging(int value);
    partial void OnidAutoraChanged();
    partial void OngodinaIzdanjaChanging(int value);
    partial void OngodinaIzdanjaChanged();
    partial void OnkolicinaChanging(int value);
    partial void OnkolicinaChanged();
    #endregion
		
		public knjiga()
		{
			this._zaduzenjes = new EntitySet<zaduzenje>(new Action<zaduzenje>(this.attach_zaduzenjes), new Action<zaduzenje>(this.detach_zaduzenjes));
			this._autor = default(EntityRef<autor>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_naslov", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string naslov
		{
			get
			{
				return this._naslov;
			}
			set
			{
				if ((this._naslov != value))
				{
					this.OnnaslovChanging(value);
					this.SendPropertyChanging();
					this._naslov = value;
					this.SendPropertyChanged("naslov");
					this.OnnaslovChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idAutora", DbType="Int NOT NULL")]
		public int idAutora
		{
			get
			{
				return this._idAutora;
			}
			set
			{
				if ((this._idAutora != value))
				{
					if (this._autor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidAutoraChanging(value);
					this.SendPropertyChanging();
					this._idAutora = value;
					this.SendPropertyChanged("idAutora");
					this.OnidAutoraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_godinaIzdanja", DbType="Int NOT NULL")]
		public int godinaIzdanja
		{
			get
			{
				return this._godinaIzdanja;
			}
			set
			{
				if ((this._godinaIzdanja != value))
				{
					this.OngodinaIzdanjaChanging(value);
					this.SendPropertyChanging();
					this._godinaIzdanja = value;
					this.SendPropertyChanged("godinaIzdanja");
					this.OngodinaIzdanjaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kolicina", DbType="Int NOT NULL")]
		public int kolicina
		{
			get
			{
				return this._kolicina;
			}
			set
			{
				if ((this._kolicina != value))
				{
					this.OnkolicinaChanging(value);
					this.SendPropertyChanging();
					this._kolicina = value;
					this.SendPropertyChanged("kolicina");
					this.OnkolicinaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="knjiga_zaduzenje", Storage="_zaduzenjes", ThisKey="id", OtherKey="sifraKnjige")]
		public EntitySet<zaduzenje> zaduzenjes
		{
			get
			{
				return this._zaduzenjes;
			}
			set
			{
				this._zaduzenjes.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="autor_knjiga", Storage="_autor", ThisKey="idAutora", OtherKey="id", IsForeignKey=true)]
		public autor autor
		{
			get
			{
				return this._autor.Entity;
			}
			set
			{
				autor previousValue = this._autor.Entity;
				if (((previousValue != value) 
							|| (this._autor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._autor.Entity = null;
						previousValue.knjigas.Remove(this);
					}
					this._autor.Entity = value;
					if ((value != null))
					{
						value.knjigas.Add(this);
						this._idAutora = value.id;
					}
					else
					{
						this._idAutora = default(int);
					}
					this.SendPropertyChanged("autor");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_zaduzenjes(zaduzenje entity)
		{
			this.SendPropertyChanging();
			entity.knjiga = this;
		}
		
		private void detach_zaduzenjes(zaduzenje entity)
		{
			this.SendPropertyChanging();
			entity.knjiga = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.korisnik")]
	public partial class korisnik : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _ime;
		
		private string _prezime;
		
		private string _adresa;
		
		private string _email;
		
		private string _brojTelefona;
		
		private string _username;
		
		private string _password;
		
		private string _uloga;
		
		private EntitySet<zaduzenje> _zaduzenjes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnimeChanging(string value);
    partial void OnimeChanged();
    partial void OnprezimeChanging(string value);
    partial void OnprezimeChanged();
    partial void OnadresaChanging(string value);
    partial void OnadresaChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnbrojTelefonaChanging(string value);
    partial void OnbrojTelefonaChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnulogaChanging(string value);
    partial void OnulogaChanged();
    #endregion
		
		public korisnik()
		{
			this._zaduzenjes = new EntitySet<zaduzenje>(new Action<zaduzenje>(this.attach_zaduzenjes), new Action<zaduzenje>(this.detach_zaduzenjes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ime", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ime
		{
			get
			{
				return this._ime;
			}
			set
			{
				if ((this._ime != value))
				{
					this.OnimeChanging(value);
					this.SendPropertyChanging();
					this._ime = value;
					this.SendPropertyChanged("ime");
					this.OnimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prezime", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string prezime
		{
			get
			{
				return this._prezime;
			}
			set
			{
				if ((this._prezime != value))
				{
					this.OnprezimeChanging(value);
					this.SendPropertyChanging();
					this._prezime = value;
					this.SendPropertyChanged("prezime");
					this.OnprezimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adresa", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string adresa
		{
			get
			{
				return this._adresa;
			}
			set
			{
				if ((this._adresa != value))
				{
					this.OnadresaChanging(value);
					this.SendPropertyChanging();
					this._adresa = value;
					this.SendPropertyChanged("adresa");
					this.OnadresaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_brojTelefona", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string brojTelefona
		{
			get
			{
				return this._brojTelefona;
			}
			set
			{
				if ((this._brojTelefona != value))
				{
					this.OnbrojTelefonaChanging(value);
					this.SendPropertyChanging();
					this._brojTelefona = value;
					this.SendPropertyChanged("brojTelefona");
					this.OnbrojTelefonaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uloga", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string uloga
		{
			get
			{
				return this._uloga;
			}
			set
			{
				if ((this._uloga != value))
				{
					this.OnulogaChanging(value);
					this.SendPropertyChanging();
					this._uloga = value;
					this.SendPropertyChanged("uloga");
					this.OnulogaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="korisnik_zaduzenje", Storage="_zaduzenjes", ThisKey="id", OtherKey="sifraKorisnika")]
		public EntitySet<zaduzenje> zaduzenjes
		{
			get
			{
				return this._zaduzenjes;
			}
			set
			{
				this._zaduzenjes.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_zaduzenjes(zaduzenje entity)
		{
			this.SendPropertyChanging();
			entity.korisnik = this;
		}
		
		private void detach_zaduzenjes(zaduzenje entity)
		{
			this.SendPropertyChanging();
			entity.korisnik = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.zaduzenje")]
	public partial class zaduzenje : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _sifraKnjige;
		
		private int _sifraKorisnika;
		
		private System.DateTime _datumZaduzenja;
		
		private EntityRef<knjiga> _knjiga;
		
		private EntityRef<korisnik> _korisnik;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnsifraKnjigeChanging(int value);
    partial void OnsifraKnjigeChanged();
    partial void OnsifraKorisnikaChanging(int value);
    partial void OnsifraKorisnikaChanged();
    partial void OndatumZaduzenjaChanging(System.DateTime value);
    partial void OndatumZaduzenjaChanged();
    #endregion
		
		public zaduzenje()
		{
			this._knjiga = default(EntityRef<knjiga>);
			this._korisnik = default(EntityRef<korisnik>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sifraKnjige", DbType="Int NOT NULL")]
		public int sifraKnjige
		{
			get
			{
				return this._sifraKnjige;
			}
			set
			{
				if ((this._sifraKnjige != value))
				{
					if (this._knjiga.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnsifraKnjigeChanging(value);
					this.SendPropertyChanging();
					this._sifraKnjige = value;
					this.SendPropertyChanged("sifraKnjige");
					this.OnsifraKnjigeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sifraKorisnika", DbType="Int NOT NULL")]
		public int sifraKorisnika
		{
			get
			{
				return this._sifraKorisnika;
			}
			set
			{
				if ((this._sifraKorisnika != value))
				{
					if (this._korisnik.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnsifraKorisnikaChanging(value);
					this.SendPropertyChanging();
					this._sifraKorisnika = value;
					this.SendPropertyChanged("sifraKorisnika");
					this.OnsifraKorisnikaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datumZaduzenja", DbType="Date NOT NULL")]
		public System.DateTime datumZaduzenja
		{
			get
			{
				return this._datumZaduzenja;
			}
			set
			{
				if ((this._datumZaduzenja != value))
				{
					this.OndatumZaduzenjaChanging(value);
					this.SendPropertyChanging();
					this._datumZaduzenja = value;
					this.SendPropertyChanged("datumZaduzenja");
					this.OndatumZaduzenjaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="knjiga_zaduzenje", Storage="_knjiga", ThisKey="sifraKnjige", OtherKey="id", IsForeignKey=true)]
		public knjiga knjiga
		{
			get
			{
				return this._knjiga.Entity;
			}
			set
			{
				knjiga previousValue = this._knjiga.Entity;
				if (((previousValue != value) 
							|| (this._knjiga.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._knjiga.Entity = null;
						previousValue.zaduzenjes.Remove(this);
					}
					this._knjiga.Entity = value;
					if ((value != null))
					{
						value.zaduzenjes.Add(this);
						this._sifraKnjige = value.id;
					}
					else
					{
						this._sifraKnjige = default(int);
					}
					this.SendPropertyChanged("knjiga");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="korisnik_zaduzenje", Storage="_korisnik", ThisKey="sifraKorisnika", OtherKey="id", IsForeignKey=true)]
		public korisnik korisnik
		{
			get
			{
				return this._korisnik.Entity;
			}
			set
			{
				korisnik previousValue = this._korisnik.Entity;
				if (((previousValue != value) 
							|| (this._korisnik.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._korisnik.Entity = null;
						previousValue.zaduzenjes.Remove(this);
					}
					this._korisnik.Entity = value;
					if ((value != null))
					{
						value.zaduzenjes.Add(this);
						this._sifraKorisnika = value.id;
					}
					else
					{
						this._sifraKorisnika = default(int);
					}
					this.SendPropertyChanged("korisnik");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591