assume cs:code,ds:data,ss:stack
data segment
db 'welcome to masm!'  ;������ʾ���ַ���(16�ֽ�)
db 02h,24h,71h		   ;����������ɫ���� 
data ends
 
stack segment ;ջ���������cx������ѭ��
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
mov ax,0b872h  		  ;����м�λ�öε�ַ
mov es,ax
mov bp,10h ;��Ϊ��ɫ���ݵ�ָ��
mov cx,3  			  ;3�δ�ѭ��
s:
push cx
mov si,0;��Ϊ�ַ�����ָ��
mov di,0;��ΪĿ���ַ��ָ��
mov cx,16 ;Сѭ��16��
 
s0:
mov al,ds:[si] ;��ȡ�ַ���������
mov es:[di+bx],al ;���ַ��������ݵ�λ���浽Ŀ���ַ
inc di 		   ;Ŀ���ַǰ��
mov al,ds:[bp] ;��ȡ��ɫ��������
mov es:[di+bx],al ;����ɫ�������ݸ�λ���浽Ŀ���ַ
inc di		   ;Ŀ���ַǰ��
inc si         ;�ַ���ǰ��
loop s0
 
pop cx 
add bx,0a0h ;������һ��
inc bp     ;��ɫҲҪ�仯
loop s 
mov ax,4c00h
int 21h
 
code ends 
end start