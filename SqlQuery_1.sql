create proc sp_invetory(
@user_id varchar(10),
@action varchar(5)
)

as
begin 

declare @cnt int
select @cnt=count(*) from inventory
if action="I"

begin
  

select @cnt 
end
if action="U"
begin 

if @cnt=0
begin

insert into waitlist(user_id,date)
select @user_id,getdate()

select  "Added to waitlist" message, scope_identity() waitlist_position
end
else 

update inventory set id=id-1
insert into reservation(user_id,date)
select @user_id,getdate()
select  scope_identity() reservation_id, dateadd(getdate(),t,05) expires_at 
end

if action="R"
begin 

select count(*) from  inventory 
select count(*) from  waitlist 
end

end