drop table if exists tuning_parts_models;
drop table if exists tuning_parts;
drop table if exists models;
drop table if exists brands;
drop table if exists categories;
drop table if exists part_brands;

create table brands (
	id int(6) not null,
	name varchar(250) not null,
	description varchar(250) not null,
	primary key (id)
);

create table part_brands (
	id int(6) not null,
  name varchar(250) not null,
  description varchar(250) not null,
  primary key (id)
);
    
create table models (
  id int(6) not null,
  name varchar(250) not null,
  production_year int(6) not null,
  brand_id int(6),
  primary key (id),
  foreign key (brand_id) references brands(id)
);
  
create table categories (
  id int(6) not null,
  name varchar(250) not null,
  description varchar(250) not null,
  primary key (id)
);
  
create table tuning_parts (
  id int(6) not null,
  name varchar(250) not null,
  category_id int(6) not null,
  brand_id int(6) not null,
  primary key (id),
  foreign key (category_id) references categories(id),
  foreign key (brand_id) references brands(id)
);

create table tuning_parts_models (
  part_id int(6),
  model_id int(6),
  installation_time_minutes int(6),
  foreign key (part_id) references tuning_parts(id),
  foreign key (model_id) references models(id)
);


-- Beispielmarken einfügen
INSERT INTO brands (id, name, description) VALUES
(1, 'Honda', 'Japanese motorcycle manufacturer'),
(2, 'Yamaha', 'Japanese motorcycle manufacturer'),
(3, 'Suzuki', 'Japanese motorcycle manufacturer'),
(4, 'Kawasaki', 'Japanese motorcycle manufacturer'),
(5, 'Ducati', 'Italian motorcycle manufacturer'),
(6, 'BMW', 'German motorcycle manufacturer');

-- Beispielkategorien einfügen
INSERT INTO categories (id, name, description) VALUES
(1, 'Exhaust', 'Tuning parts for exhaust system'),
(2, 'Suspension', 'Tuning parts for suspension system'),
(3, 'Electronics', 'Tuning parts for electronic control'),
(4, 'Brakes', 'Tuning parts for braking system'),
(5, 'Aerodynamics', 'Tuning parts for aerodynamic improvements');

-- Beispiel-Tuningteile einfügen
INSERT INTO tuning_parts (id, name, category_id, brand_id) VALUES
(1, 'Slip-On Exhaust', 1, 1),
(2, 'Rear Shock Absorber', 2, 2),
(3, 'Power Commander', 3, 3),
(4, 'Brake Pads', 4, 4),
(5, 'Windscreen', 5, 5);

-- Beispiel-Teilmarken einfügen
INSERT INTO part_brands (id, name, description) VALUES
(1, 'Akrapovič', 'Premium exhaust systems manufacturer'),
(2, 'Öhlins', 'High-performance suspension components manufacturer'),
(3, 'Dynojet', 'Leading manufacturer of fuel management systems'),
(4, 'Brembo', 'Renowned braking system manufacturer'),
(5, 'Puig', 'Specializes in motorcycle aerodynamics components'),
(6, 'Termignoni', 'Italian exhaust system manufacturer'),
(7, 'Yoshimura', 'Specializes in performance exhaust systems'),
(8, 'Galfer', 'Specializes in high-performance braking components'),
(9, 'Zero Gravity', 'Manufacturer of high-quality windscreens'),
(10, 'Rizoma', 'Manufacturer of premium motorcycle accessories');

-- Beispielmodelle einfügen
INSERT INTO models (id, name, production_year, brand_id) VALUES
(1, 'CBR1000RR', 2021, 1),
(2, 'YZF-R6', 2019, 2),
(3, 'GSX-R750', 2020, 3),
(4, 'Ninja ZX-10R', 2022, 4),
(5, 'Panigale V4', 2021, 5),
(6, 'S1000RR', 2020, 6);

-- Verknüpfungen zwischen Tuningteilen und Modellen einfügen
INSERT INTO tuning_parts_models (part_id, model_id, installation_time_minutes) VALUES
(1, 1, 30), -- Akrapovič Slip-On Exhaust for Honda CBR1000RR
(1, 2, 20), -- Akrapovič Slip-On Exhaust for Yamaha YZF-R6
(1, 3, 50), -- Akrapovič Slip-On Exhaust for Suzuki GSX-R750
(2, 1, 300), -- Öhlins Rear Shock Absorber for Honda CBR1000RR
(2, 2, 200), -- Öhlins Rear Shock Absorber for Yamaha YZF-R6
(2, 3, 100), -- Öhlins Rear Shock Absorber for Suzuki GSX-R750
(3, 1, 100), -- Dynojet Power Commander for Honda CBR1000RR
(3, 2, 60), -- Dynojet Power Commander for Yamaha YZF-R6
(3, 3, 120), -- Dynojet Power Commander for Suzuki GSX-R750
(4, 1, 100), -- Brembo Brake Pads for Honda CBR1000RR
(4, 2, 60), -- Brembo Brake Pads for Yamaha YZF-R6
(4, 3, 40), -- Brembo Brake Pads for Suzuki GSX-R750
(5, 1, 20), -- Puig Windscreen for Honda CBR1000RR
(5, 2, 30), -- Puig Windscreen for Yamaha YZF-R6
(5, 3, 40), -- Puig Windscreen for Suzuki GSX-R750
(1, 4, 30), -- Akrapovič Slip-On Exhaust for Kawasaki Ninja ZX-10R
(1, 5, 30), -- Akrapovič Slip-On Exhaust for Ducati Panigale V4
(1, 6, 40), -- Akrapovič Slip-On Exhaust for BMW S1000RR
(2, 4, 60), -- Öhlins Rear Shock Absorber for Kawasaki Ninja ZX-10R
(2, 5, 60), -- Öhlins Rear Shock Absorber for Ducati Panigale V4
(2, 6, 60); -- Öhlins Rear Shock Absorber for BMW S1000RR