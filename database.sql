DROP DATABASE IF EXISTS datapptho;
CREATE DATABASE IF NOT EXISTS datapptho;
USE datapptho;

# Load? Y
CREATE TABLE dating_users (
   global_id INT NOT NULL auto_increment,
   user_name VARCHAR(45) NOT NULL,
   PRIMARY KEY (global_id, user_name)
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='this is the actual dating user of the application';

# Load? Y
CREATE TABLE admin (
  global_id INT NOT NULL auto_increment,
  admin_name VARCHAR(45) NOT NULL,
  pay INT NOT NULL check (pay > 40000),
  PRIMARY KEY (global_id, admin_name)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 
# Load? Y
CREATE TABLE match_list (
   glob_id INT NOT NULL auto_increment,
   interested_in_id INT NOT NULL,
   PRIMARY KEY (glob_id,interested_in_id),
   KEY g_id_idx (glob_id),
   CONSTRAINT glob_id FOREIGN KEY (glob_id) REFERENCES dating_users (global_id) ON DELETE CASCADE ON UPDATE NO ACTION
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;

# Load? Y
CREATE TABLE blacklist (
   id_global INT NOT NULL auto_increment,
   email VARCHAR(45) NOT NULL,
   reason VARCHAR(45) NOT NULL,
   PRIMARY KEY (email , id_global),
   KEY id_global_idx (id_global),
   CONSTRAINT id_global FOREIGN KEY (id_global) REFERENCES dating_users (global_id) ON DELETE CASCADE ON UPDATE NO ACTION
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;

# Loads? Y
CREATE TABLE contact_info (
   globe_id INT NOT NULL auto_increment,
   phone_number VARCHAR(45) NOT NULL,
   first_name VARCHAR(45) NOT NULL,
   last_name VARCHAR(45) NOT NULL,
   PRIMARY KEY (first_name,last_name,globe_id),
   KEY globe_id_idx (globe_id),
   CONSTRAINT globe_id FOREIGN KEY (globe_id) REFERENCES dating_users (global_id) ON DELETE CASCADE ON UPDATE CASCADE
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 
# Loads? Y
CREATE TABLE objective (
   g_id INT NOT NULL auto_increment,
   intent VARCHAR(45) NOT NULL,
   PRIMARY KEY (g_id),
   KEY g_id (g_id),
   CONSTRAINT g_id FOREIGN KEY (g_id) REFERENCES dating_users (global_id) ON DELETE CASCADE ON UPDATE NO ACTION
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 
# Loads? Y
CREATE TABLE interests (
   global_interest_id INT NOT NULL auto_increment,
   interest VARCHAR(255) NOT NULL,
   PRIMARY KEY (global_interest_id, interest),
   CONSTRAINT global_interest_id FOREIGN KEY (global_interest_id) REFERENCES dating_users (global_id) ON DELETE CASCADE ON UPDATE CASCADE
   ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 
# Loads? Y
CREATE TABLE profile (
   global_id INT NOT NULL auto_increment,
   first_name VARCHAR(45) NOT NULL,
   last_name VARCHAR(45) NOT NULL,
   gender ENUM('M','F') NOT NULL,
   about_me TEXT NOT NULL,
   dob DATE NOT NULL,
   age INT NOT NULL,
   city VARCHAR(45) NOT NULL,
   picture VARCHAR(45),
   PRIMARY KEY (global_id, first_name, last_name, city),
   KEY _idx (global_id),
   CONSTRAINT global_id FOREIGN KEY (global_id) REFERENCES dating_users (global_id) ON DELETE CASCADE ON UPDATE CASCADE
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;

# Loads? Y 
CREATE TABLE credentials (
   global_credentials_id INT NOT NULL auto_increment,
   email TEXT NOT NULL,
   username VARCHAR(255) NOT NULL,
   password VARCHAR(45) NOT NULL,
   hint VARCHAR(255) NOT NULL,
   PRIMARY KEY (global_credentials_id , username),
   CONSTRAINT global_credentials_id FOREIGN KEY (global_credentials_id) REFERENCES dating_users (global_id) ON DELETE CASCADE ON UPDATE CASCADE
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 
 CREATE TABLE minimum_requirements (
   id INT NOT NULL,
   minimum_age INT NOT NULL,
   PRIMARY KEY (id)
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;

 
# Assert statements 
delimiter |
CREATE TRIGGER profile_BEFORE_INSERT BEFORE INSERT 
ON profile 
FOR EACH ROW
BEGIN
IF NEW.age < (SELECT M.minimum_age
			  FROM minimum_requirements M
			  WHERE M.id = 1
              )
 THEN
SIGNAL SQLSTATE '02000' SET message_text = 'Trying to add a minor!';
END IF;
END;

CREATE TRIGGER credentials_BEFORE_INSERT BEFORE INSERT 
ON credentials FOR EACH ROW
BEGIN
IF NEW.email IN     (SELECT B.email
			         FROM blacklist B
                     WHERE NEW.email = B.email
                     )
                     THEN
                     SIGNAL SQLSTATE '02000' SET message_text = 'blacklisted user block them';
END IF;		 
END;
|
delimiter ;

# Load min reqs
# Load profile
