assume cs:code,ds:data,ss:stack
data segment
db 'welcome to masm!'  ;定义显示的字符串(16字节)
db 02h,24h,71h		   ;定义三种颜色属性 
data ends
 
stack segment ;栈段用来存放cx做多重循环
dw 8 dup(0)
stack ends
 
code segment
start:
mov ax,data
mov ds,ax
mov ax,stack
mov ss,ax
mov sp,10h
 
mov bx,0
mov ax,0b872h  		  ;算出中间位置段地址
mov es,ax
mov bp,10h ;作为颜色数据的指针
mov cx,3  			  ;3次大循环
s:
push cx
mov si,0;作为字符串的指针
mov di,0;作为目标地址的指针
mov cx,16 ;小循环16次
 
s0:
mov al,ds:[si] ;获取字符串的数据
mov es:[di+bx],al ;将字符串的数据低位保存到目标地址
inc di 		   ;目标地址前进
mov al,ds:[bp] ;获取颜色属性数据
mov es:[di+bx],al ;将颜色属性数据高位保存到目标地址
inc di		   ;目标地址前进
inc si         ;字符串前进
loop s0
 
pop cx 
add bx,0a0h ;进行下一行
inc bp     ;颜色也要变化
loop s 
mov ax,4c00h
int 21h
 
code ends 
end start